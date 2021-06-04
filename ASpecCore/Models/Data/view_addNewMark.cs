namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_addNewMark
    {
        [StringLength(50)]
        public string mark { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid GUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string parsing { get; set; }
    }
}
