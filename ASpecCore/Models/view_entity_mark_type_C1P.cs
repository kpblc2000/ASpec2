namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_entity_mark_type_C1P
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_group_id { get; set; }

        [StringLength(15)]
        public string Item_group { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_group_long_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid guid { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime updated_at { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] version { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string Item_group_long { get; set; }

        [Key]
        [Column(Order = 6)]
        public Guid Item_group_long_guid { get; set; }

        public int? Item_group_short_id { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(10)]
        public string Item_group_short { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool Item_group_usage { get; set; }
    }
}
