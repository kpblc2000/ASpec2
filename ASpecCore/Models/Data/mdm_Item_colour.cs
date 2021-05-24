namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mdm_Item_colour
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_colour_id { get; set; }

        public int? Item_colour_id_access { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Item_colour { get; set; }

        [StringLength(20)]
        public string Item_colour_hash { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid guid { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime updated_at { get; set; }
    }
}
