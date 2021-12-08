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
            peliculasList.Add(new PeliculaModels { Id = 1, Titulo = "Avengers", Duracion = 160, Genero = "Accion", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 2, Titulo = "Mazenger Z", Duracion = 190, Genero = "Suspenso", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 3, Titulo = "La isla", Duracion = 210, Genero = "Suspenso", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 4, Titulo = "Ouija", Duracion = 210, Genero = "Terror", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 5, Titulo = "Chuky", Duracion = 150, Genero = "Terror", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 6, Titulo = "La monja", Duracion = 260, Genero = "Terror", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 11, Titulo = "P1Accion", Duracion = 100, Genero = "accion", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 12, Titulo = "P2Accion", Duracion = 200, Genero = "accion", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 13, Titulo = "P3Terror", Duracion = 151, Genero = "Terror", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 14, Titulo = "P4Terror", Duracion = 85, Genero = "Terror", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 15, Titulo = "P5Suspenso", Duracion = 500, Genero = "Suspenso", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 16, Titulo = "P6Suspenso", Duracion = 105, Genero = "Suspenso", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 17, Titulo = "P7Drama", Duracion = 99, Genero = "Drama", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 18, Titulo = "P8Drama", Duracion = 60, Genero = "Drama", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 19, Titulo = "P9Drama", Duracion = 199, Genero = "Drama", Director = director });
            peliculasList.Add(new PeliculaModels { Id = 20, Titulo = "P10Ficcion", Duracion = 164, Genero = "Ficcion", Director = director });
            
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

        // Accion que muestra en una vista la lista de peliculas
        // envio datos a una lista
        // El modelo es una lista de peliculas. Es un alista
        public ActionResult PeliculasView()
        {
            var peliculas = getPeliculas();
            return View("ListPeliculas", peliculas);
        }

        //Tarea en una acción llamada PEliculaGanadora regresar a su vista una sola pelicula
        //***Con los datos de su preferencia

        // ViewBag
        // Es un contenedor de datos u objetos que no necesariamente pertenecen
        // al modelo. Ejemplo string int bool, etc. que permite regresar valores
        // a la vista

        //public ActionResult ViewBagExample()
        //{
        //    // El nombre del ViewBag y se convierte en lo que yo le setee a la derecha
        //    // en este caso es un string 
        //    // https://localhost:44325/Pelicula/ViewBagExample
        //    //
        //    ViewBag.Saludo = "Hola Mundo";
        //    return View("ViewBagExample");
        //}

        public ActionResult ViewBagExample()
        {
            DirectorModels director = new DirectorModels();
            director.Nombre = "AldoViewBagExample";
            ViewBag.Pelicula = new PeliculaModels { Id = 100, Titulo = "PeliculaViewBagExample", Duracion = 900, Genero = "Aprendizaje", Director = director };
            ViewBag.Saludo = "Hola Mundo";
            return View("ViewBagExample");
        }


        //Ejercicio Crear accion Dias que regrese a una vista los dias de la
        //semana --- Pueden utilizar ViewBag o algún modelo

        public ActionResult DiasSemana()
        {
            ViewBag.dias = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            return View();
        }


        public List<PeliculaModels> ExampleLinq1()
        {
            var peliculasQuery = (from peliculas in getPeliculas()
                                  where peliculas.Genero == "Terror"
                                  select peliculas
                                  ).ToList();

            return peliculasQuery;
        }

        /// <summary>
        /// Ejemplo de ordenamiento
        /// </summary>
        /// <returns></returns>
        public List<PeliculaModels> ExampleLinq2()
        {
            var peliculasQuery = (from peliculas in getPeliculas()
                                  orderby peliculas.Titulo ascending
                                  select peliculas
                                  ).ToList();

            return peliculasQuery;
        }

        /// <summary>
        /// Ejemplo de ordenamiento doble y filtrado
        /// </summary>
        /// <returns></returns>
        public List<PeliculaModels> ExampleLinq3()
        {
            var peliculasQuery = (from peliculas in getPeliculas()
                                  where peliculas.Genero == "Terror"
                                  orderby peliculas.Titulo, peliculas.Duracion ascending
                                  select peliculas
                                  ).ToList();

            return peliculasQuery;
        }


        //Consulta con linq que filtre las pelicuas donde el genero sea Terror o suspendo
        // y la duración sea mayor a 200 minutos ordenadas por duracion y titulo

        public List<PeliculaModels> ExampleLinq4()
        {
            var peliculasQuery = (from peliculas in getPeliculas()
                                  where ( peliculas.Genero == "Terror" || peliculas.Genero == "Suspenso")
                                  && peliculas.Duracion > 200
                                  orderby peliculas.Duracion, peliculas.Titulo descending
                                  select peliculas
                                 ).ToList();
            return peliculasQuery;
        }

        // Es mas diercta y lineal Lamba expresion que Liq

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>

        public ActionResult ViewLinqExamples()
        {
            var linq1 = ExampleLinq1();
            var linq2 = ExampleLinq2();
            var linq3 = ExampleLinq3();

            var Lambda1 = ExampleLambda1();
            var Lamda2 = ExampleLambda2();
            var Lamda33 = ExampleLambda33();
            var Lamda3 = ExampleLambda3();
            var Lamda4 = ExampleLambda4();
            return View(Lamda4);
        }

        //Lambda Expression es una sentencia mas avanzada en relacion a linq, es mas directa y lineal 
        //Que se vuelve mas comnpleja en cuanto va creciendo la consulta

        public List<PeliculaModels> ExampleLambda1()
        {
            var peliculasQuery = (from peliculas in getPeliculas()
                                  where peliculas.Genero == "Terror"
                                  select peliculas
                                  ).ToList();
            //De esta coleccion de datos recupera las que son de genero terror
            var peliculaLambda = getPeliculas().Where(w => w.Genero == "Terror").ToList();

            return peliculaLambda;
        }


        public List<PeliculaModels> ExampleLambda2()
        {
            var peliculasQuery = (from peliculas in getPeliculas()
                                  where peliculas.Genero == "Terror"
                                  orderby peliculas.Titulo descending, peliculas.Duracion descending
                                  select peliculas
                                  ).ToList();


            //De esta coleccion de datos recupera las que son de genero terror
            var peliculaLambda = getPeliculas().Where(w => w.Genero == "Terror").
                OrderByDescending(o => o.Titulo).ThenByDescending(o => o.Duracion).ToList();

            return peliculaLambda;
        }


        // Peliculas que el genero sea terror o suspendo y duracion < 200
        // ordenadas por genero ascendente

        public List<PeliculaModels> ExampleLambda33()
        {
            // Doris
            var peliculasQuery = (from peliculas in getPeliculas()
                                  where ( peliculas.Genero == "Terror" || peliculas.Genero == "Suspenso" )
                                  && peliculas.Duracion < 200 
                                  orderby peliculas.Genero ascending
                                  select peliculas
                                 ).ToList();

            // De la coleccion de datos recupera ls que son de genero terror 
            //var peliculaLambda = getPeliculas().Where(w => (w.Genero == "Terror" || w.Genero == "Suspenso") && w.Duracion < 200)
            // .OrderBy(o => o.Genero)
            // .ToList();

            return peliculasQuery;
        }

        //1.-Con lambda obtener las peliculas que sean de duracion mayora 200 minutos y menor
        //a 250 minutos ordenadas por titulo de manera ascendente y duracion de manera descendente

        public List<PeliculaModels> ExampleLambda3()
        {
            var peliculaLambda = getPeliculas().Where(w => w.Duracion > 200 && w.Duracion < 250)
            .OrderBy(o => o.Titulo)
            .ThenByDescending(o => o.Duracion)
            .ToList();
            return peliculaLambda;
        }

        //2.-Con lambda obtener las peliculas que el genero sea Terro o Suspenso y la duracion sea
        //menor a 200 ordenadas por genero ascendente

        public List<PeliculaModels> ExampleLambda4()
        {
            var peliculaLambda = getPeliculas().Where(w => (w.Genero == "Terror" || w.Genero == "Suspenso") && w.Duracion < 200)
            .OrderBy(o => o.Genero)
            .ToList();
            return peliculaLambda;
        }


    }   // fin de la clase PeliculaController
}