using Microsoft.AspNetCore.Mvc;
using Tanitim.Models;
namespace Tanitim.Controllers
{
    public class ZaferController : Controller
    {
        List<Personel> pers = new List<Personel>() {
           new Personel{PersId=1,Ad="Refik",Maas=500},
           new Personel{PersId=2,Ad="Fuat",Maas=600},
           new Personel{PersId=3,Ad="Ramiz",Maas=700},
           new Personel{PersId=4,Ad="İsmail",Maas=500},
           new Personel{PersId=5,Ad="Mesut",Maas=1600},
           new Personel{PersId=6,Ad="Adnan",Maas=1700},

        };
        //global değişken olarak tanımlandı
        public IActionResult Index()
        {
            ViewBag.Mehmet = "Mehmet'in Bilgisi";
            ViewData["Zafer"] = "Zafer Beyin Bilgileri";
            TempData["Enes"] = "Enes Bilgileri";
            var liste = pers.ToList();//lambda deniyor
            //select * from personel


            //yukarıda kullanılan yapı kullanacak
            return View(liste);
        }
        public IActionResult Listem()
        {
            var liste=(from s in pers select s).ToList();
            //linq yapısı select * from personel
            return View(liste);
        }
        [HttpGet]
        public IActionResult Delete (int? id)
        {
            var tek=pers.Where(x=>x.PersId==id).FirstOrDefault();//lambda kullanımı
            //var tek=(from s in Pers where s.PersId==id).FirstOfDefault();linq
            //select * from pers where PersId=id
            return View(tek);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var tek = pers.Where(x => x.PersId == id).FirstOrDefault();//lambda kullanımı
            //var tek=(from s in Pers where s.PersId==id).FirstOfDefault();linq
            //select * from pers where PersId=id
            return View(tek);
        }

    }
}
