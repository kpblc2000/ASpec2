namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_npcon_changed_product
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_npcon_changes { get; set; }

        public int? LastVerID_NPCon { get; set; }

        public int? ID_MDM { get; set; }

        public string НаименованиеMDM { get; set; }

        [StringLength(250)]
        public string НаименованиеNPCon { get; set; }

        public int? Item_group_id { get; set; }

        public int? ГабаритнаяДлина { get; set; }

        public int? ГабаритнаяВысота { get; set; }

        public int? ГабаритнаяТолщина { get; set; }

        public int? Длина { get; set; }

        public int? Высота { get; set; }

        public int? Толщина { get; set; }

        public decimal? Площадь { get; set; }

        public decimal? Объем { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Вес { get; set; }

        public decimal? КоличествоКанатов { get; set; }

        public int? ВысотаБезСтупенькиРеновация { get; set; }

        public int? ID_ВнутреннегоСлоя { get; set; }

        public decimal? ОбъемВнутреннегоСлоя { get; set; }

        public int? ID_ФасадЧастьОсн { get; set; }

        public decimal? ОбъемФасадЧастьОсн { get; set; }

        public int? ID_ФасадЧастьБок { get; set; }

        public decimal? ОбъемФасадЧастьБок { get; set; }

        public int? ID_ТорецВерх_зуб { get; set; }

        public decimal? ОбъемТорецВерх_зуб { get; set; }

        public double? ОбъемНаружногоСлоя { get; set; }

        public double? ОбъемУтеплителя { get; set; }

        public int? ТолщинаВнутреннегоСлоя { get; set; }

        public int? ТолщинаНаружногоСлоя { get; set; }

        public int? ТолщинаУтеплителя { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_NPCon { get; set; }

        public bool? id_existance { get; set; }

        public int? chk_KTD { get; set; }
    }
}
