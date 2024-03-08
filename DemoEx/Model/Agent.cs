namespace DemoEx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agent")]
    public partial class Agent
    {
        [Key]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string AgentTypeID { get; set; }

        [StringLength(300)]
        public string Address { get; set; }

        [StringLength(12)]
        public string INN { get; set; }

        [StringLength(9)]
        public string KPP { get; set; }

        [StringLength(100)]
        public string DirectorName { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Logo { get; set; }

        public int Priority { get; set; }

        public virtual AgentType AgentType { get; set; }
    }
}
