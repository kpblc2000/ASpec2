namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_node
    {
        public int? id_normdoc_pobj { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_objecttype_pobj { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string unitsguid_pobj { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool isagreed { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime createdate { get; set; }

        public DateTime? agreedate { get; set; }

        [StringLength(50)]
        public string created_original_login { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string created_comp_name { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string created_username { get; set; }

        [StringLength(50)]
        public string agree_original_login { get; set; }

        [StringLength(50)]
        public string agree_comp_name { get; set; }

        [StringLength(50)]
        public string agree_username { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(200)]
        public string unicname { get; set; }

        public int? id_album { get; set; }

        [StringLength(50)]
        public string name_alb { get; set; }

        [StringLength(250)]
        public string description_alb { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_prod { get; set; }

        public int? id_album_prod { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string blkname { get; set; }

        public int? prodlength { get; set; }

        public int? prodheight { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_objecttype { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool isproduct { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string objecttypename { get; set; }

        public bool? isendproduct { get; set; }

        public int? id_album_list { get; set; }

        public int? id_normdoc { get; set; }

        [StringLength(50)]
        public string doctype { get; set; }

        [StringLength(50)]
        public string doccode { get; set; }

        [StringLength(250)]
        public string description { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(4)]
        public string unitcode { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string unitname { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string graphsymbol_rus { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(200)]
        public string unicname_trim { get; set; }

        [StringLength(50)]
        public string listnum_prod { get; set; }

        [StringLength(50)]
        public string listnum { get; set; }

        public string file_path { get; set; }

        public bool? actual { get; set; }

        public int? prod_thickness { get; set; }

        public bool? outdoor { get; set; }

        public int? id_type4mark { get; set; }

        [StringLength(50)]
        public string typeShortName { get; set; }
    }
}
