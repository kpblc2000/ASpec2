namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mdm_Item_modification
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_modification_id { get; set; }

        public int? Item_modification_id_access { get; set; }

        [StringLength(5)]
        public string Item_modification_code { get; set; }

        public int? Item_modification_type_id { get; set; }

        public int? Side_id { get; set; }

        public int? Item_modification_point { get; set; }

        public int? Item_modification_measure { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] version { get; set; }
    }
}
