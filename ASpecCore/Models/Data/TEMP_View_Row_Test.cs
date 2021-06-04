namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMP_View_Row_Test
    {
        [Key]
        [Column("ID сырья", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_сырья { get; set; }

        [Key]
        [Column("Вес за 1м.", Order = 1)]
        public decimal Вес_за_1м_ { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Сырьё { get; set; }

        [Key]
        [Column("Тип норм.документа", Order = 3)]
        [StringLength(50)]
        public string Тип_норм_документа { get; set; }

        [Key]
        [Column("№ ГОСТа", Order = 4)]
        [StringLength(50)]
        public string C__ГОСТа { get; set; }

        [Key]
        [Column("Описани ГОСТа", Order = 5)]
        [StringLength(250)]
        public string Описани_ГОСТа { get; set; }

        [Column("ед.измерения")]
        [StringLength(50)]
        public string ед_измерения { get; set; }

        [Key]
        [Column("ед.изм.веса", Order = 6)]
        [StringLength(50)]
        public string ед_изм_веса { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string unicname { get; set; }

        [Key]
        [Column(Order = 8)]
        public byte largewidth { get; set; }

        [Key]
        [Column(Order = 9)]
        public byte smallwidth { get; set; }

        [Key]
        [Column(Order = 10)]
        public byte thickness { get; set; }

        [StringLength(1)]
        public string precision { get; set; }
    }
}
