namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_item_const_forming_C1P
    {
        [Key]
        [Column(Order = 0)]
        public Guid guid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string forming_dimension { get; set; }

        [StringLength(50)]
        public string forming_lifting { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string Hand_mark_no_colour { get; set; }

        public short? Length { get; set; }

        public short? Height { get; set; }

        public short? Thickness { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_construction_id { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid Item_construction_guid { get; set; }
    }
}
