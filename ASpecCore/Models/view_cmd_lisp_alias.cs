namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_cmd_lisp_alias
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_lisp { get; set; }

        public string description { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string lisp { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_alias { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string alias { get; set; }
    }
}
