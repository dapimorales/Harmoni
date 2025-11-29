using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Threading.Tasks;
using static Harmoni.API.Models.Api_Models_PayloadModels;

namespace Harmoni.API.Models
{

    public class CoopApiResponse
    {
        public string? CoopCode { get; set; } 

        public string ResponseCode { get; set; } = "";

        public string ResponseMessage { get; set; } = "";

        public DateTime ResponseTime   { get; set; }

        [JsonPropertyName("coopList")]
        public List<CoopAcross> CoopList{ get; set; } = new();
    }
    
    public class MemberApiResponse
    {
        public string? MemberCode { get; set; }

        public string ResponseCode { get; set; } = "";

        public string ResponseMessage { get; set; } = "";

        public DateTime ResponseTime   { get; set; }

        [JsonPropertyName("MemberList")]
        public List<MemberAcross> MemberList {  get; set; } = new();
    }
    

    public class BalanceApiResponse
    {
        public string ResponseCode { get; set; } = "";

        public string ResponseMessage { get; set; } = "";

        public DateTime ResponseTime{ get; set; }

        public string? MemberCode { get; set; } 

        public string? CoopCode { get; set; }

        public BalanceAcross? Balance {  get; set; }

        [JsonPropertyName("balanceList")]
        public List<BalanceAcross> balanceList {  get; set; } = new();
    }

    public class TransferApiResponse
    {
        public string ResponseCode { get; set; } = "";

        public string ResponseMessage { get; set; } = "";

        public DateTime ResponseTime { get; set; }

        public string? TransactionCode { get; set; }

        public TransferAcross? Tranfer { get; set; }

        [JsonPropertyName("memberList")]
        public List<TransferAcross> TransferList { get; set;} = new();
    internal class Api_Models_PayloadResponse
    {
    }
}
