using System;

namespace zehBet.sinifler
{
    public class Sefer
    {
        public int SeferId { get; set; }
        public int TrenId { get; set; }
        public decimal Ucreti { get; set; }
        public string VarisSuresi
        {
            get
            {
                TimeSpan fark = VarisZamani - KalkisZamani;

                return $"{fark.Hours}s:{fark.Minutes}dk";
            }
        }
        public int BaslangicIstasyonId { get; set; }
        public int BitisIstasyonId { get; set; }
        public DateTime KalkisZamani { get; set; }
        public DateTime VarisZamani { get; set; }

        public Tren Tren { get; set; } = new Tren();
        public Istasyon BaslangicIstasyon { get; set; } = new Istasyon();
        public Istasyon BitisIstasyon { get; set; } = new Istasyon();

        public override string ToString()
        {
            return SeferId + "-" + BaslangicIstasyon.Adi;

        }

    }
}
