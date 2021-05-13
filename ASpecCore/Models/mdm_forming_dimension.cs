namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mdm_forming_dimension
    {
        [Key]
        [Column(Order = 0)]
        public Guid guid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string forming_dimension { get; set; }
    }
}
