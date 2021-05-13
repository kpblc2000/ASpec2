namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Marks_and_modifications from EXCEL")]
    public partial class Marks_and_modifications_from_EXCEL
    {
        [StringLength(255)]
        public string Status { get; set; }

        [StringLength(255)]
        public string by_modificators { get; set; }

        [StringLength(255)]
        public string by_apertures { get; set; }

        [Key]
        [StringLength(255)]
        public string necessity { get; set; }

        [StringLength(255)]
        public string console { get; set; }

        [StringLength(255)]
        public string Tooth { get; set; }

        [StringLength(255)]
        public string Insulation { get; set; }

        [StringLength(255)]
        public string loop_release { get; set; }

        [StringLength(255)]
        public string brace { get; set; }

        [StringLength(255)]
        public string backs { get; set; }

        [StringLength(255)]
        public string Author { get; set; }

        [StringLength(255)]
        public string type_of_aperture { get; set; }

        public int? id_mdm { get; set; }

        public int? id_aperture { get; set; }

        [StringLength(255)]
        public string aperture_geometry { get; set; }

        public string OP_p { get; set; }

        public string BP_p { get; set; }

        public string comment { get; set; }

        public int? id_ap_p { get; set; }

        public int? id_mdm_p { get; set; }

        [StringLength(255)]
        public string NormMark { get; set; }

        [StringLength(50)]
        public string Item_group_MDM { get; set; }
    }
}
