namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product_modification
    {
        [Key]
        public int id_prod_modif { get; set; }

        public int id_object_prod { get; set; }

        public int id_objecttype { get; set; }

        public int id_modif { get; set; }

        public int? id_param { get; set; }

        public int? id_mod_param_value_pool { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? createdate { get; set; }

        [Required]
        [StringLength(50)]
        public string created_original_login { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] version { get; set; }

        public int? Item_modification_id { get; set; }

        public int? Item_construction_id { get; set; }

        [StringLength(4000)]
        public string modif_param_value { get; set; }

        public bool? modif_exist { get; set; }

        public byte modif_number { get; set; }

        public virtual mod_param_value_pool mod_param_value_pool { get; set; }

        public virtual modification_parameter modification_parameter { get; set; }

        public virtual modificationType4object_type modificationType4object_type { get; set; }

        public virtual product product { get; set; }
    }
}
