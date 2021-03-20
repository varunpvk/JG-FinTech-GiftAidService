namespace JG.FinTech.Models
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [DataContract]
    public struct GiftAidResponse
    {
        [JsonIgnore]
        public string DonorID { get; set; }
        
        /// <summary>
        /// 25
        /// </summary>
        [DataMember]
        public double GiftAidAmount { get; set; }

        [DataMember]
        [JsonIgnore]
        public double DonationAmount { get; set; }
    }
}
