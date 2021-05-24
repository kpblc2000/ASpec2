namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERRORS_IN_APERTURES-WD")]
    public partial class ERRORS_IN_APERTURES_WD
    {
        public long? MarkOrd { get; set; }

        public int? id_mdm { get; set; }

        [StringLength(50)]
        public string P_Mark { get; set; }

        [Key]
        [StringLength(50)]
        public string RightMark { get; set; }

        [StringLength(50)]
        public string p_t { get; set; }

        [StringLength(50)]
        public string p_h { get; set; }

        [StringLength(50)]
        public string p_b { get; set; }
    }
}
