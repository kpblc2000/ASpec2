namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_TEMP1C
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_endprod_ver { get; set; }

        public decimal? end_prod_volume { get; set; }

        public decimal? end_prod_weight { get; set; }

        public decimal? end_prod_area { get; set; }

        public decimal? count_ropes { get; set; }

        public int? Item_construction_id { get; set; }

        public string Hand_mark_no_colour { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string blkname { get; set; }

        public int? Item_group_id { get; set; }

        public int? prodlength { get; set; }

        public int? prodheight { get; set; }

        public int? prod_thickness { get; set; }

        public int? height_full { get; set; }

        public int? length_full { get; set; }

        public int? thickness_full { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_prod { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_npcon_changes { get; set; }
    }
}
