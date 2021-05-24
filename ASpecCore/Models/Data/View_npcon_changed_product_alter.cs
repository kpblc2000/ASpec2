namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_npcon_changed_product_alter
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LastVerID_NPCon { get; set; }

        public int? ID_MDM { get; set; }

        public string НаименованиеMDM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string НаименованиеNPCon { get; set; }

        public int? ГабаритнаяДлина { get; set; }

        public int? ГабаритнаяВысота { get; set; }

        public int? ГабаритнаяТолщина { get; set; }

        public int? Длина { get; set; }

        public int? Высота { get; set; }

        public int? Толщина { get; set; }

        public decimal? Площадь { get; set; }

        public decimal? Объем { get; set; }

        public decimal? Вес { get; set; }

        public decimal? КоличествоКанатов { get; set; }

        public int? ВысотаБезСтупенькиРеновация { get; set; }

        public int? ДлинаЛевогоТорцаНаружногоСлоя { get; set; }

        public int? ДлинаПравогоТорцаНаружногоСлоя { get; set; }

        public int? ДлинаТорцаНаружногоСлоя { get; set; }

        public double? ОбъемВнутреннегоСлоя { get; set; }

        public double? ОбъемНаружногоСлоя { get; set; }

        public double? ОбъемУтеплителя { get; set; }

        public int? ТолщинаВнутреннегоСлоя { get; set; }

        public int? ТолщинаНаружногоСлоя { get; set; }

        public int? ТолщинаУтеплителя { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_NPCon { get; set; }
    }
}
