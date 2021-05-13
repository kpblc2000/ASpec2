namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class loaded_Job_Files
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string f_path { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "datetime2")]
        public DateTime loaded_date { get; set; }
    }
}
