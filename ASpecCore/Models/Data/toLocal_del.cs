namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class toLocal_del
    {
        [Key]
        [StringLength(255)]
        public string Hand_mark_no_colour { get; set; }
    }
}
