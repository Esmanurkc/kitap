using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ders.Models
{
    public class Kitap
    {
        
        public string? KitapAdı { get; set; }
        public string ? YazarAdı { get; set; }
        public DateTime YayınlanmaTarihi { get; set; }
        public string ? Türü { get; set; }
        public int SayfaSayısı { get; set; }
        public decimal Fiyat { get; set; }
    }
}

    
