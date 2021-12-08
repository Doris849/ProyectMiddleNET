namespace TecgurusMiddleEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Laptop
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public double? ProductCost { get; set; }

        [StringLength(50)]
        public string ProductDescription { get; set; }

        [Column(TypeName = "image")]
        public byte[] ProductImage { get; set; }
    }
}
