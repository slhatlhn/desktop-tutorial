using System;
namespace zehBet.sinifler
{
    public class Bilet
    {
        public int Id { get; set; }
        public int SeferId { get; set; }
        public int YolcuId { get; set; }
        public Guid BiletNo { get; set; }
        public string Sinifi { get; set; }
        public string Tipi { get; set; }
        public string Pnr { get; set; }
        public decimal Ucreti { get; set; }
        public string KoltukNo { get; set; }

        public DateTime AlisTarihi { get; set; }
        // public string Vagon { get; set; }
        public Kullanici Yolcu { get; set; }
        public Sefer Sefer { get; set; }

    }
}



