namespace DemoEx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductSale")]
    public partial class ProductSale
    {
        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(50)]
        public string AgentName { get; set; }

        [Column(TypeName = "date")]
        public DateTime SaleDate { get; set; }

        public int ProductCount { get; set; }

        public int ID { get; set; }
    }
}
