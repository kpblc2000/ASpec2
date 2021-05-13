namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_Product_Mark_C1P
    {
        public int? Product_id { get; set; }

        [StringLength(255)]
        public string Product { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string Hand_mark_no_colour { get; set; }

        [StringLength(15)]
        public string Item_group { get; set; }

        [StringLength(100)]
        public string Item_group_long { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_construction_id { get; set; }

        public short? Length { get; set; }

        public short? Height { get; set; }

        public short? Thickness { get; set; }

        public int? Item_group_id { get; set; }

        public int? Item_group_long_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid guid { get; set; }

        public Guid? item_group_guid { get; set; }

        public Guid? item_group_long_guid { get; set; }
    }
}
