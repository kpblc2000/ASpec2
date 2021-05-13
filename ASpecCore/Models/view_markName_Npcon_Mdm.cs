namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_markName_Npcon_Mdm
    {
        [Key]
        [StringLength(255)]
        public string unicname_trim { get; set; }
    }
}
