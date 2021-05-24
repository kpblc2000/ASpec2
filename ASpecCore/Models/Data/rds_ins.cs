namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("report.rds_ins")]
    public partial class rds_ins
    {
        [Key]
        [Column(Order = 0)]
        public int id_rds { get; set; }

        public int? id_object { get; set; }

        [Key]
        [Column(Order = 1)]
        public string mark { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int thickness { get; set; }

        [Key]
        [Column(Order = 3)]
        public string height_width { get; set; }

        public int? id_modif { get; set; }

        public int? mod_num { get; set; }

        public int? mod_num_plus { get; set; }
    }
}
