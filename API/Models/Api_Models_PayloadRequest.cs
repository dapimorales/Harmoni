using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmoni.API.Models
{

    public class TransferPayload
    {
        public string coopCode { get; set; } = "";

        public string memberCode { get; set; } = "";

        public string benefCode { get; set; } = "";

        public Double Amount { get; set; }

        public Double Fee  { get; set; }

        public string transferRef { get; set; } = "";

        public string remaks { get; set; } = "";
    }

    public class BalancePayload
    {
        public string memberCode { get; set; } = "";

        public Double amount { get; set; }  
    }

    public class MemberPayload
    {
        public string name { get; set; } = "";

        public string address { get; set; } = "";

        public string code { get; set; } = "";

        public string coopCode { get; set; } = "";
    }

    public class CoopPayload
    {
        public string name { get; set; } = "";

        public string address { get; set; } = "";

        public string code { get; set; } = "";
    }
    internal class Api_Models_PayloadRequest
    {
    }
}
