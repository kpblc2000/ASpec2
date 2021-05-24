namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class albName_exep
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(300)]
        public string alb_name { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool actual { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "datetime2")]
        public DateTime created_at { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string creator_name { get; set; }
    }
}
