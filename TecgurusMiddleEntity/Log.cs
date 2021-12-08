namespace TecgurusMiddleEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log
    {
        public int ID { get; set; }

        [Required]
        public string LevelExc { get; set; }

        [Required]
        public string CallSite { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public string StackTrace { get; set; }

        [Required]
        public string InnerException { get; set; }

        [Required]
        public string AdditionalInfo { get; set; }

        [Column(TypeName = "date")]
        public DateTime LoggedOnDate { get; set; }

        [Required]
        public string URL { get; set; }

        [Required]
        public string UserID { get; set; }
    }
}
