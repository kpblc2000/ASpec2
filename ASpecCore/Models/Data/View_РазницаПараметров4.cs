namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_РазницаПараметров4
    {
        [StringLength(50)]
        public string ФИО { get; set; }

        public string Марка { get; set; }

        [Column("Вес 1С")]
        [StringLength(50)]
        public string Вес_1С { get; set; }

        [Column("Вес NpCon")]
        public decimal? Вес_NpCon { get; set; }

        [Column("Вес МДМ")]
        public float? Вес_МДМ { get; set; }

        [Column("Объём 1С")]
        [StringLength(50)]
        public string Объём_1С { get; set; }

        [Column("Объём NPCon")]
        public decimal? Объём_NPCon { get; set; }

        [Column("Объём МДМ")]
        public float? Объём_МДМ { get; set; }

        [Column("Длина 1С")]
        [StringLength(50)]
        public string Длина_1С { get; set; }

        [Column("Длина NPCon")]
        public int? Длина_NPCon { get; set; }

        [Column("Длина МДМ")]
        public short? Длина_МДМ { get; set; }

        [Column("Высота 1С")]
        [StringLength(50)]
        public string Высота_1С { get; set; }

        [Column("Высота NPCon")]
        public int? Высота_NPCon { get; set; }

        [Column("Высота МДМ")]
        public short? Высота_МДМ { get; set; }

        [Column("Толщина 1С")]
        [StringLength(10)]
        public string Толщина_1С { get; set; }

        [Column("Толщина NPCon")]
        public int? Толщина_NPCon { get; set; }

        [Column("Толщина МДМ")]
        public short? Толщина_МДМ { get; set; }

        [Column("Площадь 1С")]
        [StringLength(50)]
        public string Площадь_1С { get; set; }

        [Column("Площадь NPCon")]
        public decimal? Площадь_NPCon { get; set; }

        [Column("Площадь МДМ")]
        public float? Площадь_МДМ { get; set; }

        [Column("Габ.толщина 1С")]
        [StringLength(50)]
        public string Габ_толщина_1С { get; set; }

        [Column("Габ.толщина NPCon")]
        public int? Габ_толщина_NPCon { get; set; }

        [Column("Габ.толщина МДМ")]
        public short? Габ_толщина_МДМ { get; set; }

        [Key]
        [StringLength(50)]
        public string статус { get; set; }
    }
}
