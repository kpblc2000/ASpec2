namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_endproduct_cut
    {
        public int? id_normdoc_pobj { get; set; }

        public int? id_object { get; set; }

        [StringLength(200)]
        public string unicname { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string name_alb { get; set; }

        public int? id_object_prod { get; set; }

        [StringLength(250)]
        public string blkname { get; set; }

        public int? prodlength { get; set; }

        public int? prodheight { get; set; }

        public int? id_objecttype { get; set; }

        [StringLength(200)]
        public string unicname_trim { get; set; }

        public int? prod_thickness { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_endprod_ver { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int modification_num { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime created_at { get; set; }

        [StringLength(50)]
        public string creator_username { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_eprod_album { get; set; }

        public Guid? itm_conFrm_guid { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string status_name { get; set; }

        public int? length_full { get; set; }

        public int? height_full { get; set; }

        public int? thickness_full { get; set; }

        public decimal? end_prod_weight { get; set; }

        public decimal? end_prod_volume { get; set; }

        [StringLength(50)]
        public string frm_dimension { get; set; }

        [StringLength(50)]
        public string frm_lifting { get; set; }

        public Guid? formin_type_guid { get; set; }

        public decimal? end_prod_area { get; set; }

        public bool? renovation { get; set; }

        public int? id_rep_pod { get; set; }

        [StringLength(30)]
        public string prod_name { get; set; }

        public int? id_line { get; set; }

        public int? id_tskmng_item { get; set; }
    }
}
