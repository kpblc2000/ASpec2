namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_modificators
    {
        public long? MarkOrd { get; set; }

        [StringLength(50)]
        public string Марка { get; set; }

        [StringLength(1)]
        public string Консоль { get; set; }

        [Column("Выступ(Зуб)")]
        [StringLength(1)]
        public string Выступ_Зуб_ { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Утеплитель { get; set; }

        [Key]
        [Column("Петлевой выпуск", Order = 1)]
        [StringLength(6)]
        public string Петлевой_выпуск { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string Скоба { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(8)]
        public string Торец { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string Автор { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string Проем { get; set; }
    }
}
