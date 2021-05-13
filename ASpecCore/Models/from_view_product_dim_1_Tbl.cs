namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class from_view_product_dim_1_Tbl
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string blkname { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string unicname_trim { get; set; }

        public int? высота { get; set; }

        public int? длина { get; set; }

        public int? толщина { get; set; }

        [Column("толщина(габаритная)")]
        public int? толщина_габаритная_ { get; set; }

        public decimal? вес { get; set; }

        public decimal? объём { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "datetime2")]
        public DateTime created_at { get; set; }

        public Guid? itm_conFrm_guid { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_prod { get; set; }

        public decimal? end_prod_area { get; set; }
    }
}
