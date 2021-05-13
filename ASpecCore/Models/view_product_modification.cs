namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_product_modification
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_prod_modif { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_modif { get; set; }

        public int? Item_modification_id { get; set; }

        [StringLength(255)]
        public string Item_modification_code { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Item_modification_type { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_prod { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_objecttype { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string objecttypename { get; set; }

        public int? id_param { get; set; }

        [StringLength(100)]
        public string param_name { get; set; }

        [StringLength(4000)]
        public string modif_param_value { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? createdate { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string created_original_login { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] version { get; set; }

        public int? Item_construction_id { get; set; }

        public int? id_mod_param_value_pool { get; set; }

        public bool? modif_exist { get; set; }

        public int? type_input { get; set; }

        public int? proof_KB { get; set; }
    }
}
