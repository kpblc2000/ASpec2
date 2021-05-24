namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("report.ALLPLAN_KB_differ")]
    public partial class ALLPLAN_KB_differ
    {
        [StringLength(255)]
        public string НаименованиеNPCon { get; set; }

        [StringLength(255)]
        public string Марка { get; set; }

        public int? id_object { get; set; }

        public int? id_endprod_ver { get; set; }

        public int? ОсновнаяДлина_АП { get; set; }

        public int? ОсновнаяДлина_КБ { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ОДлина_ош { get; set; }

        public int? ГабаритнаяДлина_АП { get; set; }

        public int? ГабаритнаяДлина_КБ { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ГДлина_ош { get; set; }

        public int? ОсновнаяВысота_АП { get; set; }

        public int? ОсновнаяВысота_КБ { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ОВысота_ош { get; set; }

        public int? ГабаритнаяВысота_АП { get; set; }

        public int? ГабаритнаяВысота_КБ { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string ГВысота_ош { get; set; }

        public int? ОсновнаяТолщина_АП { get; set; }

        public int? ОсновнаяТолщина_КБ { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string ОТолщина_ош { get; set; }

        public int? ГабаратинаяТолщина_АП { get; set; }

        public int? ГабаритнаяТолщина_КБ { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string ГТолщина_ош { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Площадь_АП { get; set; }

        public decimal? Площадь_КБ { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(2)]
        public string Площадь_ош { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Объем_АП { get; set; }

        public decimal? Объем_КБ { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(2)]
        public string Объем_ош { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Вес_АП { get; set; }

        public decimal? Вес_КБ { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(2)]
        public string Вес_ош { get; set; }

        public int? КоличествоКанатов_АП { get; set; }

        [StringLength(4000)]
        public string КоличествоКанатов_КБ { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(2)]
        public string Канаты_ош { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ОбъемВнутреннегоСлоя_АП { get; set; }

        public decimal? ОбъемВнутреннегоСлоя_КБ { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(2)]
        public string ОбъемВнутреннегоСлоя_ош { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ОбъемНаружногоСлоя_АП { get; set; }

        public decimal? ОбъемНаружногоСлоя_КБ { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(2)]
        public string ОбъемНаружногоСлоя_ош { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ОбъемУтеплителя_АП { get; set; }

        public decimal? ОбъемУтеплителя_КБ { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(2)]
        public string ОбъемУтеплителя_ош { get; set; }

        public int? ТолщинаВнутреннегоСлоя_АП { get; set; }

        public decimal? ТолщинаВнутреннегоСлоя_КБ { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(2)]
        public string ТолщинаВнутреннегоСлоя_ош { get; set; }

        public int? ТолщинаНаружногоСлоя_АП { get; set; }

        public decimal? ТолщинаНаружногоСлоя_КБ { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(2)]
        public string ТолщинаНаружногоСлоя_ош { get; set; }

        public int? ТолщинаУтеплителя_АП { get; set; }

        public decimal? ТолщинаУтеплителя_КБ { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(2)]
        public string ТолщинаУтеплителя_ош { get; set; }

        [Key]
        [Column("Есть несоответствия", Order = 16)]
        [StringLength(6)]
        public string Есть_несоответствия { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(202)]
        public string Несоответствия_АП_КБ { get; set; }

        public int? Not_AP_max_ver { get; set; }
    }
}
