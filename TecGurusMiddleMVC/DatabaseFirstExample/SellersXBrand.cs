namespace TecGurusMiddleMVC.DatabaseFirstExample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SellersXBrand
    {
        public int ID { get; set; }

        public int IDSeller { get; set; }

        public int? IDBrand { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
