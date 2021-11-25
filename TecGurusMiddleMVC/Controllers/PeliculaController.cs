using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecGurusMiddleMVC.Models;

namespace TecGurusMiddleMVC.Controllers
{
    public class PeliculaController : Controller
    {
        // GET: Pelicula
        public ActionResult Index()
        {
            return View("View");
        }

        //public ActionResult Estreno()
        //{
        //    return View();
        //}


        //https://localhost:44325/Nominadas
        //https://localhost:44325/Pelicula/Ganadoras
        public ActionResult Ganadoras()
        {
            return View("Nominadas");
        }

        // Redirigir a una vista de otro folder
        public ActionResult Estreno()
        {
            return View("~/View/Data/AllData.cshtml");
        }

        // Redirigur de una Action a otro Action
        public ActionResult Estreno2()
        {
            return View("Index","Data");
        }

        //Tipos de resultado: Es la respuesta que puedde dar una accion
        //Es una accion generica que regresa diferentes resultados
        // Es la clase base base para todos los resultados de accion MVC
        // genera rdos dinamicos en base a una petición


        public ActionResult RetirarDinero()
        {
            int SaltoTotal = 1000;
            int SaldoRetirado = 9000;
            if (SaldoRetirado <= SaltoTotal)
            {
                // muestra la vista Saldo que contiene la leyenda Saldo disponible
                return View("Saldo");
            }
            else
            {
                return Content("<h1><b>Saldo insuficiente</b></h1>");
            }

        }

        //public JsonResult ExampleJson()
        //{

        //}

        // regresar una lista de 3 peliculas en el metodo getPeliculas
        // y obtenerlas en el Action Peliculas ***
        // Aun no las muestren en la vista solo corroboren con un debug
        // private List<PeliculaModels> getPEliculas()
        // El metodo getPEliculas() lo debemos llamr en el return y que traiga
        // las 3 peliculas
        //{

        //}

        private List<PeliculaModels> getPeliculas()
        {
            List<PeliculaModels> peliculasList = new List<PeliculaModels>();
            DirectorModels director = new DirectorModels();
            director.Nombre = "Aldo Director de pelicula";
            peliculasList.Add(new PeliculaModels { Id = 1, Titulo = "P1", Duracion = 160, Genero = "accion", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 1, Titulo = "P2", Duracion = 161, Genero = "accion", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 1, Titulo = "P3", Duracion = 162, Genero = "Terror", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 1, Titulo = "P4", Duracion = 163, Genero = "Terror", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 1, Titulo = "P5", Duracion = 164, Genero = "Suspenso", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 1, Titulo = "P6", Duracion = 165, Genero = "Suspenso", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 1, Titulo = "P7", Duracion = 166, Genero = "drama", Director = director });
            return peliculasList;
        }

        // metodo con sobrecarga
        //public ViewResult Peliculas(int Id)
        //{
        //    var peliculas = getPeliculas();
        //    return View("ListPeliculas");
        //}

        // [HttpPost]
        //public ViewResult Peliculas()
        //{
        //    var peliculas = getPeliculas();
        //    return View("ListPeliculas");
        //}


        //public ViewResult Peliculas()
        //{
        //    return View();
        //}


        //Todos son GET
        public JsonResult Peliculas()
        {
            var peliculas = getPeliculas();
            return Json(peliculas, JsonRequestBehavior.AllowGet);
        }

        //Accion que muestra en una visya la lista de peliculas
        // envio datos a una lista
        // El modelo es una lista de peliculas. Es un alista
        public ActionResult PeliculasView()
        {
            var peliculas = getPeliculas();
            return View("ListPeliculas", peliculas);
        }


    }
}