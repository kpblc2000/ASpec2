namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_end_prod_Status_fromExcel
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

        [StringLength(50)]
        public string H { get; set; }

        [StringLength(50)]
        public string I { get; set; }
    }
}
