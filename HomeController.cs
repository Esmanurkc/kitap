using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ders.Models;

namespace ders.Controllers;

public class HomeController : Controller
{
      public IActionResult Index()
        {
            Kitap kitap = new Kitap
            {
                KitapAdı = "Yaralasar",
                YazarAdı = "Maral Atmaca",
                YayınlanmaTarihi = new DateTime(2021, 02, 16),
                Türü = "Kurgu",
                SayfaSayısı = 448,
                Fiyat = 200
            };

            return View(kitap);}


}
