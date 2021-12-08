namespace TecgurusMiddleEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [StringLength(13)]
        public string RFC { get; set; }

        [StringLength(50)]
        public string BusinessName { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(30)]
        public string SecondlastName { get; set; }

        [StringLength(6)]
        public string FiscalPerson { get; set; }

        public int? FederalEntityID { get; set; }

        [StringLength(300)]
        public string Municipality { get; set; }

        [StringLength(30)]
        public string Colony { get; set; }

        [StringLength(40)]
        public string Street { get; set; }

        [StringLength(50)]
        public string StreetNumber { get; set; }

        [StringLength(50)]
        public string SuiteNumber { get; set; }

        [StringLength(20)]
        public string CP { get; set; }

        public virtual Order Order { get; set; }
    }
}
