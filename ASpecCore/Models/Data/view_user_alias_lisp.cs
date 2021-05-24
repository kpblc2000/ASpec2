namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_user_alias_lisp
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string user_login { get; set; }

        [StringLength(50)]
        public string domain { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string alias { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string lisp { get; set; }
    }
}
