namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_MARKS_MODS_to_delete_from_MDM
    {
        [StringLength(201)]
        public string M_M_MDM1 { get; set; }

        public int? Item_con_id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_mod_id { get; set; }

        public int? ID_mods_group { get; set; }

        [StringLength(255)]
        public string Rmark_name { get; set; }

        [StringLength(5)]
        public string mod_name { get; set; }
    }
}
