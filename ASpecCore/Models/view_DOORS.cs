namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_DOORS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Марка { get; set; }

        public int? id_mdm { get; set; }

        [Column("Код проема")]
        public int? Код_проема { get; set; }

        [Key]
        [Column("Тип проема", Order = 1)]
        [StringLength(2)]
        public string Тип_проема { get; set; }

        [StringLength(50)]
        public string Ширина { get; set; }

        [StringLength(50)]
        public string Длина { get; set; }
    }
}
