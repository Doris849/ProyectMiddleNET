using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TecGurusMiddleMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "EjemploNominadas",
                url: "Nominadas",
                defaults: new { controller = "Pelicula", action = "Ganadoras" }
                );

            routes.MapRoute(
                name: "Ejemplo",
                url: "Peliculas",
                defaults: new { controller = "Pelicula", action = "Index" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
