namespace TecgurusMiddleEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClientDetail
    {
        public int Id { get; set; }

        public int ClientID { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required]
        [StringLength(30)]
        public string SecondlastName { get; set; }

        public int FederalEntityID { get; set; }

        [Required]
        [StringLength(300)]
        public string Municipality { get; set; }

        [Required]
        [StringLength(30)]
        public string Colony { get; set; }

        [Required]
        [StringLength(40)]
        public string Street { get; set; }

        [Required]
        [StringLength(50)]
        public string StreetNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string SuiteNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string CP { get; set; }

        [Required]
        [StringLength(50)]
        public string PaymentMethod { get; set; }

        [StringLength(50)]
        public string AccountNumber { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public virtual Client Client { get; set; }

        public virtual FederalEntity FederalEntity { get; set; }
    }
}
