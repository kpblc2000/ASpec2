namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class some_new_mods
    {
        [StringLength(22)]
        public string modificator { get; set; }

        [StringLength(50)]
        public string mark { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? creation_date { get; set; }

        [Key]
        [StringLength(150)]
        public string GUID { get; set; }

        [StringLength(20)]
        public string MDM_mod { get; set; }

        [StringLength(20)]
        public string Robot_mod { get; set; }
    }
}
