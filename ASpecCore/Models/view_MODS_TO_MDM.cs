namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_MODS_TO_MDM
    {
        [Key]
        [Column(Order = 0)]
        public string marks { get; set; }

        [Key]
        [Column(Order = 1)]
        public string modification { get; set; }

        public int? t_a { get; set; }
    }
}
