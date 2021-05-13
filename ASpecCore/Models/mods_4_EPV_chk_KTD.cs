namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mods_4_EPV_chk_KTD
    {
        [Key]
        [Column(Order = 0)]
        public int id_modif { get; set; }

        public int? Item_modification_id { get; set; }

        public int? Item_modification_id_access { get; set; }

        [StringLength(255)]
        public string Item_modification_code { get; set; }

        public int? Item_modification_type_id { get; set; }

        public int? Side_id { get; set; }

        public int? Item_modification_point { get; set; }

        public int? Item_modification_measure { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int? type_input { get; set; }

        public int? proof_KB { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool is_single { get; set; }
    }
}
