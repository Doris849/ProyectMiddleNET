using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TecGurusMiddleMVC.CodeFirstExample
{
    public class Students
    {
        // 1.Las anotaciones para EF siven para especificar los detalles
        // de las columnas de la tabla. Solo son decoradores y para validar el Front end
        // 2. las data annotation-notaciones tambien sirven para restringir los datos de la vista
        // que vienen en el modelo. Sirven para validar, puedo meter mensaje

        [Key]
        public int StudentId { get; set; }

        [Required] // no permite nulos
        public int Age { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public string Email { get; set; }


    }  // fin
}