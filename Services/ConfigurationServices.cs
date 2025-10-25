using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmoni.Data;
using Harmoni.Models;
using Microsoft.EntityFrameworkCore;


namespace Harmoni.Services
{
    internal class ConfigurationServices
    {
        private readonly AppDbContext _db;
        public ConfigurationServices(AppDbContext db) => _db = db;

        public async Task<Configuration?> GetConfig()
        {
            var config = await _db.Configurations.FirstOrDefaultAsync(x => x.Id == 1);
            return config;
        }

        public async Task addOrUpdate(String terminologi1, String terminologi2,
            string terminologi3, decimal exchangeRate, decimal inhouseFee,
            decimal accrossFee)
        {
            Boolean isNew = false;
            var config = await _db.Configurations.FirstOrDefaultAsync(x => x.Id == 1);
            if (config == null)
            {
                isNew = true;
                config = new Configuration();
            }

            config.terminologi1 = terminologi1;
            config.terminologi2 = terminologi2;
            config.terminologi3 = terminologi3;
            config.exchangeRate = exchangeRate;
            config.transferInhouseFee = inhouseFee;
            config.transferAcrossFee = accrossFee;

            if (isNew)
            {
                _db.Add(config);

            }

            else
            {
                _db.Update(config);
            }

            await _db.SaveChangesAsync();
        }
    }
}
