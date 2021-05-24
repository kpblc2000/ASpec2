namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_Item_construction_C1P
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_construction_id { get; set; }

        public int? Item_construction_id_access { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string Hand_mark_no_colour { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_group_id { get; set; }

        public short? Length { get; set; }

        public short? Height { get; set; }

        public short? Thickness { get; set; }

        public short? Formwork { get; set; }

        [StringLength(10)]
        public string Electrics { get; set; }

        public int? Steps { get; set; }

        public int? First_step { get; set; }

        public float? Weight { get; set; }

        public float? Volume { get; set; }

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

        public float? Surface_area { get; set; }

        public short? Thickness_size { get; set; }

        public float? Metal_weight_max { get; set; }
    }
}
