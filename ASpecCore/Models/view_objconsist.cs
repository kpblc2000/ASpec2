namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_objconsist
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_cons { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_objTypeMainObj { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string objTypeNameMainObj { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string unicnameMainObj { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool isproductMainObj { get; set; }

        public bool? isendproductMainObj { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_subobject { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_objecttype { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string objecttypename { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(200)]
        public string unicname { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool isproduct { get; set; }

        public bool? isendproduct { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int count { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(4)]
        public string len_units { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(200)]
        public string unicname_trim { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(200)]
        public string unicTrim_MainObj { get; set; }

        public bool? actual { get; set; }

        public bool? actualMainObj { get; set; }

        public int? id_mark4subelem { get; set; }

        public int? id_type4mark { get; set; }

        public int? id_type4markMainObj { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal blanklen { get; set; }
    }
}
