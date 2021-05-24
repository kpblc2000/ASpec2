namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mdm_Item_modification_type_t
    {
        [Key]
        public int id_modif_Type { get; set; }

        public int? Item_modification_type_id { get; set; }

        public int? Item_modification_type_rank { get; set; }

        [Required]
        [StringLength(50)]
        public string Item_modification_type { get; set; }
    }
}
