namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_1C_mods_1
    {
        [Column(TypeName = "numeric")]
        public decimal? id_npcon { get; set; }

        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal ID_MDM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Модификатор { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Item_modification_ID { get; set; }

        public string Значение { get; set; }
    }
}
