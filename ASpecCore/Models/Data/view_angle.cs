namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_angle
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

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_raw { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal weight { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(4)]
        public string weight_units { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_angle { get; set; }

        [Key]
        [Column(Order = 12)]
        public byte largewidth { get; set; }

        [Key]
        [Column(Order = 13)]
        public byte smallwidth { get; set; }

        [StringLength(1)]
        public string precision { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_normdoc { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string doctype { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string doccode { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(250)]
        public string description { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal thickness { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(200)]
        public string unicname_trim { get; set; }

        public bool? actual { get; set; }
    }
}
