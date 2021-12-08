using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TecGurusMiddleMVC.CodeFirstExample
{
    public class Teachers
    {

        //CodeFirst
        //Crear tabla Teacher con Id, Nombre , Cedula, grupo -mediante codeFirst
        //Y  en student agregar un GroupID

        //Unicos comandos que vamos a ocupar
        //add-migration migracion2
        //Update-Database

        [Key]
        public int TeacherId { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }
                
        public int Cedula { get; set; }

        public string Grupo { get; set; }



    } // fin de la clase
}