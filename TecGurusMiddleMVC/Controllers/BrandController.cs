using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecGurusMiddleMVC.DatabaseFirstExample;

namespace TecGurusMiddleMVC.Controllers
{
    public class BrandController : Controller
    {
        // Se saco de cada ActionResult para no estarlo repitiendo en cada metodo
        DBContextDBFirst dBContextDB = new DBContextDBFirst();

        // GET: Brand
        public ActionResult Index()
        {
            
            var brans = dBContextDB.Brands.ToList();
            //Una vez Corregido el error mostrar los datos en la vista
            //con una tabla o los h3

            var sellersXBrands = dBContextDB.SellersXBrands.ToList();
            //Solo recupera un registro en este caso en base a mi condicion Where
            var brandLazyLoading = sellersXBrands.Where(w => w.IDBrand == 1).FirstOrDefault();
            var BranLazy = brandLazyLoading.Brand.Nombre;
            return View();
        }

        public ActionResult Sellers()
        {
            var sellers = dBContextDB.Sellers.Where(w => w.Edad >= 29).ToList();
            return View(sellers);
        }




    } // fin
}