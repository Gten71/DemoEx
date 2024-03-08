namespace DemoEx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(50)]
        public string TypeOfProduction { get; set; }

        [Required]
        [StringLength(10)]
        public string ArticleNumber { get; set; }

        public int? ProductionPersonCount { get; set; }

        public int? ProductionWorkshopNumber { get; set; }

        public int? MinCostForAgent { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}
