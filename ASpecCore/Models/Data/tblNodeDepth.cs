namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblNodeDepth")]
    public partial class tblNodeDepth
    {
        public int id { get; set; }

        public int id_album { get; set; }

        [Required]
        [StringLength(50)]
        public string nodeName { get; set; }

        public int Depth { get; set; }

        public int Thickness { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual album album { get; set; }
    }
}
