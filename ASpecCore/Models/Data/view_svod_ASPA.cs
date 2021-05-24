namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_svod_ASPA
    {
        [StringLength(50)]
        public string A { get; set; }

        public DateTime? B { get; set; }

        [Key]
        [StringLength(50)]
        public string C { get; set; }

        [StringLength(50)]
        public string D { get; set; }

        [StringLength(50)]
        public string E { get; set; }

        [StringLength(50)]
        public string F { get; set; }

        [StringLength(50)]
        public string G { get; set; }

        public int? H { get; set; }

        [StringLength(50)]
        public string I { get; set; }

        public DateTime? J { get; set; }

        public DateTime? K { get; set; }

        [StringLength(50)]
        public string L { get; set; }

        [StringLength(50)]
        public string M { get; set; }

        [StringLength(50)]
        public string N { get; set; }

        [StringLength(50)]
        public string O { get; set; }

        [StringLength(50)]
        public string P { get; set; }

        [StringLength(50)]
        public string Q { get; set; }

        [StringLength(50)]
        public string R { get; set; }

        public DateTime? S { get; set; }

        public DateTime? T { get; set; }

        [StringLength(100)]
        public string U { get; set; }

        [StringLength(50)]
        public string V { get; set; }

        [StringLength(50)]
        public string W { get; set; }

        [StringLength(50)]
        public string X { get; set; }

        public int? Y { get; set; }

        [StringLength(50)]
        public string Z { get; set; }
    }
}
