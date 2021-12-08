using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecgurusMiddleFactories;
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
        public ActionResult ajax_ChangePage(int page)
        {
            var products = productModelFactory.PrepareToProductViewModel(page);
            return PartialView("_ProductModelList", products);

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
