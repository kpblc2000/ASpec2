namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_forming_type_C1P
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string forming_dimension { get; set; }

        [StringLength(50)]
        public string forming_lifting { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid guid { get; set; }
    }
}
