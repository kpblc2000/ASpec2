namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_mark4OSOSf
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_cons { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_subobject { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string unicname { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int count { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string unicname_trim { get; set; }

        public bool? actual { get; set; }

        public int? id_mark4subelem { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(4)]
        public string len_units { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal blanklen { get; set; }
    }
}
