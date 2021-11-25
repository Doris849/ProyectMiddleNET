using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecGurusMiddleMVC.Models
{
    public class PeliculaModels
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public string Genero { get; set; }

        public DirectorModels Director { get; set; }

    }
}