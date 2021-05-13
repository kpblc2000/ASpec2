namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class params_loaded_from_1c
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal ID_MDM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string NameN { get; set; }

        [StringLength(50)]
        public string Name_with_param { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Length { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Width { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Height { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Square_of_ObjGeom { get; set; }

        public int? Item_modification_id { get; set; }

        [StringLength(200)]
        public string type_of_panel { get; set; }
    }
}
