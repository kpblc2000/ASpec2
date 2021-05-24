namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mdm_Item_group_long_t
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_group_long_id { get; set; }

        public int? Item_group_long_id_access { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Item_group_long { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid guid { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime updated_at { get; set; }

        public int? Item_group_short_id { get; set; }
    }
}
