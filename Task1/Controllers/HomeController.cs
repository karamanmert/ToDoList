using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;


namespace Task1.Controllers
{
    public class HomeController : Controller
    {

        public static List<item> items = new List<item>();

        // GET: Home
        public ActionResult Index()
        {

            return View(items);
        }


        [HttpGet]
        public ActionResult Yeni()
        {


            return View("Form");
        }

        [HttpPost]
        public ActionResult Kaydet(item itm)
        {
            
            if(itm.id==0)
            {
                items.Add(new item(itm.not,itm.tarih));
            }
            else
            {
                var guncellenecek = items.FirstOrDefault(m => m.id == itm.id);
                guncellenecek.not = itm.not;
                guncellenecek.tarih = itm.tarih;
            }

            return RedirectToAction("Index");
        }

        public ActionResult Guncelle(int id)
        {
            var model = items.FirstOrDefault(m => m.id == id);
            return View("Form",model);
        }
        public ActionResult Sil(int id)
        {
            var silinecek = items.FirstOrDefault(m => m.id == id);
            items.Remove(silinecek);
            return RedirectToAction("Index");

        }
    }
}