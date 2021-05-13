namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class addmods_from_C1
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal ID_MDM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Item_modification_id { get; set; }
    }
}
