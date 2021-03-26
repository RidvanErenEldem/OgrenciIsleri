using System;

namespace DataAccess.DTO
{
    public class DersDTO
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string FakulteAd { get; set; }
        public string BolumAd { get; set; }
        public int BolumId { get; set; }
        public Byte Kredi { get; set; }
        public string AkademisyenAd { get; set; }
        public int AkademisyenId { get; set; }
        public int Donem { get; set; }
    }
}
