namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mdm_Item_construction_modification
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_construction_modification_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_construction_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_modification_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid guid { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "datetime2")]
        public DateTime updated_at { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] version { get; set; }
    }
}
