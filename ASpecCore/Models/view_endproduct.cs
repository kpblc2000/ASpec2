namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_endproduct
    {
        public int? id_normdoc_pobj { get; set; }

        public int? id_object { get; set; }

        public int? id_objecttype_pobj { get; set; }

        [StringLength(4)]
        public string unitsguid_pobj { get; set; }

        public bool? isagreed { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? createdate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? agreedate { get; set; }

        [StringLength(50)]
        public string created_original_login { get; set; }

        [StringLength(50)]
        public string created_comp_name { get; set; }

        [StringLength(50)]
        public string created_username { get; set; }

        [StringLength(50)]
        public string agree_original_login { get; set; }

        [StringLength(50)]
        public string agree_comp_name { get; set; }

        [StringLength(50)]
        public string agree_username { get; set; }

        [StringLength(200)]
        public string unicname { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string name_alb { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string description_alb { get; set; }

        public int? id_object_prod { get; set; }

        public int? id_album_prod { get; set; }

        [StringLength(250)]
        public string blkname { get; set; }

        public int? prodlength { get; set; }

        public int? prodheight { get; set; }

        public int? id_objecttype { get; set; }

        public bool? isproduct { get; set; }

        [StringLength(50)]
        public string objecttypename { get; set; }

        public bool? isendproduct { get; set; }

        [StringLength(200)]
        public string unicname_trim { get; set; }

        [StringLength(50)]
        public string listnum_prod { get; set; }

        public string file_path { get; set; }

        public bool? actual { get; set; }

        public int? prod_thickness { get; set; }

        public bool? outdoor { get; set; }

        public int? id_type4mark { get; set; }

        public Guid? guid { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? updated_at { get; set; }

        [StringLength(50)]
        public string unitname { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_endprod_ver { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_end_prod { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int modification_num { get; set; }

        [StringLength(250)]
        public string modification_descr { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "datetime2")]
        public DateTime created_at { get; set; }

        [StringLength(50)]
        public string creator_username { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool eprod_actual { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ver_status { get; set; }

        public int? execution_ver { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_eprod_album { get; set; }

        public Guid? itm_conFrm_guid { get; set; }

        public string eprod_file_path { get; set; }

        public Guid? objtypguid { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string status_name { get; set; }

        [StringLength(50)]
        public string forming_dimension { get; set; }

        [StringLength(50)]
        public string forming_lifting { get; set; }

        [StringLength(255)]
        public string Hand_mark_no_colour { get; set; }

        public short? Length { get; set; }

        public short? Height { get; set; }

        public short? Thickness { get; set; }

        public int? length_full { get; set; }

        public int? height_full { get; set; }

        public int? thickness_full { get; set; }

        public decimal? end_prod_weight { get; set; }

        public decimal? end_prod_volume { get; set; }

        public int? id_workfile { get; set; }

        public bool? in_design { get; set; }

        [StringLength(50)]
        public string frm_dimension { get; set; }

        [StringLength(50)]
        public string frm_lifting { get; set; }

        public Guid? formin_type_guid { get; set; }

        public decimal? end_prod_area { get; set; }

        public int? Item_construction_id { get; set; }

        public int? id_mdm { get; set; }

        [StringLength(250)]
        public string nrm_unicname_trim { get; set; }

        public bool? renovation { get; set; }

        public decimal? volume { get; set; }

        public bool? buying_part { get; set; }

        public int? rotate_layers { get; set; }

        public decimal? prod_weight { get; set; }
    }
}
