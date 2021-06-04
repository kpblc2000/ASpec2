namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_TEMP_PR_last_UUID
    {
        public int? id { get; set; }

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

        [StringLength(50)]
        public string UUID_file { get; set; }
    }
}
