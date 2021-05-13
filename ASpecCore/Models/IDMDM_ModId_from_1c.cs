namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IDMDM_ModId_from_1c
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal ID_MDM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Item_modification_id { get; set; }
    }
}
