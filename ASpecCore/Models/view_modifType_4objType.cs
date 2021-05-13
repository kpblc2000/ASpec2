namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_modifType_4objType
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_objecttype { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_modif { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? createdate { get; set; }

        [StringLength(50)]
        public string created_original_login { get; set; }

        [StringLength(255)]
        public string Item_modification_code { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string objecttypename { get; set; }

        public int? type_input { get; set; }

        public int? proof_KB { get; set; }
    }
}
