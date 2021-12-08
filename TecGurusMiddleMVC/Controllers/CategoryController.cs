using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecgurusMiddleServices;

namespace TecGurusMiddleMVC.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            CategoryService categoryService = new CategoryService();
            var categories = categoryService.GetCategories();
            return View(categories);

        }    


        } // fin de clase
    }