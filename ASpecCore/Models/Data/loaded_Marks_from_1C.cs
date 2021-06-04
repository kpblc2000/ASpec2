namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class loaded_Marks_from_1C
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal ID_MDM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Volume { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Area { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Length { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Width { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Height { get; set; }
    }
}
