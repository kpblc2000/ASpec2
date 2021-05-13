namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_objalbumorgost
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string unicname { get; set; }

        [StringLength(50)]
        public string name_alb { get; set; }

        [StringLength(50)]
        public string doctype { get; set; }

        [StringLength(50)]
        public string doccode { get; set; }

        [StringLength(50)]
        public string blkname { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string unicname_trim { get; set; }

        [StringLength(50)]
        public string listnum { get; set; }

        public bool? actual { get; set; }
    }
}
