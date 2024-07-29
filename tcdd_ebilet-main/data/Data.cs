using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using zehBet.sinifler;

namespace zehBet.data
{
    static public class Data
    {
        static public List<Istasyon> Istasyonlar { get; set; } = new List<Istasyon>();
        static public List<Tren> Trenler { get; set; } = new List<Tren>();
        static public List<Sefer> Seferler { get; set; } = new List<Sefer>();

        public static void GetData()
        {
            var faker = new Faker();
            var trenFaker = new Faker<Tren>()
               .RuleFor(t => t.Id, f => f.IndexFaker)
               .RuleFor(t => t.TrenAdi, f => f.Commerce.ProductName())
               .RuleFor(t => t.TrenKapasitesi, f => f.Random.Number(100, 500));

            var istasyonFaker = new Faker<Istasyon>()
                .RuleFor(i => i.Id, f => f.IndexFaker )
                .RuleFor(i => i.Adi, f => f.Address.CityPrefix())
                .RuleFor(i => i.Sehir, f => f.Address.City());
            var trenler = trenFaker.Generate(20);
            var istasyonlar = istasyonFaker.Generate(30);
            var seferFaker = new Faker<Sefer>()
           .RuleFor(s => s.SeferId, f => f.IndexFaker + 1)
           .RuleFor(s => s.TrenId, f => f.Random.Number(0, 20))
           .RuleFor(s => s.BaslangicIstasyonId, f => f.Random.Number(0, 29))
           .RuleFor(s => s.BitisIstasyonId, f => f.Random.Number(0, 29))
           .RuleFor(s => s.Ucreti, f => f.Finance.Amount(100,800,0))
           .RuleFor(s => s.KalkisZamani, f => f.Date.Between(DateTime.Now, DateTime.Now.AddDays(30)))
           .RuleFor(s => s.VarisZamani, (f, s) => f.Date.Between(s.KalkisZamani, s.KalkisZamani.AddDays(2)))
           .RuleFor(s => s.BaslangicIstasyon, (f, s) => s.BaslangicIstasyon = istasyonlar.First(i=> i.Id == s.BaslangicIstasyonId));


            // Veri örnekleri oluşturuluyor
            var seferler = seferFaker.Generate(200);
        
            Seferler.AddRange(seferler);
            Istasyonlar.AddRange(istasyonlar);
            Trenler.AddRange(trenler);

        }
   

    }
}
