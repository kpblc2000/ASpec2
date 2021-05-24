namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class no_weight_TEMP
    {
        [Key]
        [StringLength(50)]
        public string dwg_mark { get; set; }

        [StringLength(50)]
        public string right_mark { get; set; }
    }
}
