namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class factory_old
    {
        [Key]
        [Column(Order = 0)]
        public int id_fact { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string f_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string f_prefix { get; set; }
    }
}
