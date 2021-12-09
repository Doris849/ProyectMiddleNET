using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecgurusMiddleFactories;
using TecgurusMiddleModel;
using TecgurusMiddleServices;

// El namespace en Entity Data Model (EDM) es es un contenedor abstracto para tipos de entidad,
// tipos complejos y asociaciones. Los espacios de nombres en EDM son similares a los espacios
// de nombres en un lenguaje de programación: proporcionan contexto para los objetos que
// contienen y proporcionan una forma de eliminar la ambigüedad de los objetos que tienen
// el mismo nombre (pero que están contenidos en diferentes espacios de nombres).


namespace TecGurusMiddleMVC.Controllers
{
    // En los proyectos de tipo Web API, los controllers o controladores son
    // los objetos que se ejecutan al recibir una petición. El controlador usará
    // Entity Framework para comunicarse con el nivel de base de datos. Los
    public class ProductController : Controller
    {
        // Se instancia ProductModelFactory
        ProductModelFactory productModelFactory = new ProductModelFactory();
        // GET: Product

        // Accion a ejecutar
        public ActionResult Index()
        {
            //ProductService productService = new ProductService();
            var products = productModelFactory.PrepareToProductViewModel();
            return View(products);
        }

        //Una vista parcial es un fragmento de una vista padre
        //que no contiene directamente un MasterPage "Layout"
        //necesita ser llamado desde una vista padre, aunque desde el cotroller puedo actualizar la vista parcial
        //Mantener y administrar mis elementos html

        //Acciones de busqueda y acciones de paginado

        // public ActionResult ajax_ChangePage(int page)
        //.. logica para cambiar de pagina,teniendo los datos para el cambio de pagina -> los actualizariamos
        //en la vista parcial

        [HttpPost]
        public ActionResult ajax_ChangePage(int page, string valueSearch)
        {
            var products = productModelFactory.PrepareToProductViewModel(page, valueSearch);
            return PartialView("_ProductModelList", products);
        }

        // al hacer el submit hace todo el modelo, me interesa el value seaarch, ya no recibe el page

        [HttpPost]
        public ActionResult Ajax_Search(ProductViewModel model)
        {
            //Con el valor que traiga d ela vista hacer un filtrado de datos en factory
            //Con el valor de lavista hacer un filtrado de datos en Factory
            // simpre va (1) siempre va a estar en la pagina 1 uando fieltre
            var products = productModelFactory.PrepareToProductViewModel(1, model.ValueSearch);
            return PartialView("_ProductModelList", products);
        }

        // se crea la vista Create (mouse derecho, add view MVC 5 View, no es una vista parcial
        // se marca la opción USe a Layout page

        [HttpGet]
        public ActionResult Create()
        {
            return null;
        }









        //Tarea Crear Servicio para Categoria, crear controller Category y mostrar
        //en una vista index del controller Category todas las categorias 
        //ordenadas por nombre de manera  ascendente
        //Las columnas a mostrar en la tabla son :CategoryId , CategoryName

        //Bootstrap es una tecnologia de Front end construida mediante hojas de estilo
        //CSS y scripts es decir Javascripts-> lo que ya esta construido son clases
        //Clases de CSS no estamos hablando de POO 
        //Creando diseños Responsivos es decir adaptable a diferentes resoluciones de 
        //tamaño de dispositivos
        //Quien creo Boostrap fue Twitter
    }
}
