namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_mark_parsing
    {
        public int id { get; set; }

        [Required]
        [StringLength(150)]
        public string GUID { get; set; }

        [StringLength(50)]
        public string mark { get; set; }

        [Required]
        public string parsing { get; set; }

        [Required]
        [StringLength(50)]
        public string blk_name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? creation_date { get; set; }

        [StringLength(50)]
        public string created_original_login { get; set; }
    }
}
