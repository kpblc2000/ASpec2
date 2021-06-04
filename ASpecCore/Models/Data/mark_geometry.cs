namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mark_geometry
    {
        public int id { get; set; }

        [StringLength(1000)]
        public string marks { get; set; }

        public int? Length { get; set; }

        public int? Height { get; set; }

        public int? Thickness { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? date { get; set; }

        [StringLength(50)]
        public string created_original_login { get; set; }
    }
}
