namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MetPref")]
    public partial class MetPref
    {
        [Key]
        [Column(Order = 0)]
        public int id_me { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string pref { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created { get; set; }

        public string author { get; set; }
    }
}
