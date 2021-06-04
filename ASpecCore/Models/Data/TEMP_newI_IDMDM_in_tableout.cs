namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMP_newI_IDMDM_in_tableout
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal ID_MDM { get; set; }
    }
}
