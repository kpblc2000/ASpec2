namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("view_end_prod_consist&Mark_2ASPA")]
    public partial class view_end_prod_consist_Mark_2ASPA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string objecttypename { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string unicname_trim { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_endprod_ver { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal object_count { get; set; }

        [StringLength(250)]
        public string blkname { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(200)]
        public string MarkName { get; set; }

        [StringLength(50)]
        public string name_alb { get; set; }

        public string file_path { get; set; }
    }
}
