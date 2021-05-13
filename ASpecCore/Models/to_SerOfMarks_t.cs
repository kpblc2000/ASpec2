namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class to_SerOfMarks_t
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal id_mdm { get; set; }

        [StringLength(150)]
        public string Project { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Mark { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ProjectType { get; set; }
    }
}
