namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_mark_code_type_C1P
    {
        public bool? Item_group_usage { get; set; }

        [StringLength(15)]
        public string Item_group { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string Item_group_long { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid guid { get; set; }

        public int? Item_group_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_group_long_id { get; set; }
    }
}
