namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_OS_Ropes
    {
        [Key]
        [StringLength(250)]
        public string blkname { get; set; }
    }
}
