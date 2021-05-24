namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("report.ALLPLAN_to_NPCon")]
    public partial class ALLPLAN_to_NPCon
    {
        [Key]
        public int id_ap { get; set; }

        [StringLength(100)]
        public string Тип { get; set; }

        [StringLength(255)]
        public string НаименованиеNPCon { get; set; }

        [StringLength(255)]
        public string RightMark { get; set; }

        public int? ГабаритнаяТолщина { get; set; }

        public int? Толщина { get; set; }

        public int? Длина { get; set; }

        public int? ГабаритнаяДлина { get; set; }

        public int? Высота { get; set; }

        public int? ГабаритнаяВысота { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Площадь { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Объем { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Вес { get; set; }

        public int? КоличествоКанатов { get; set; }

        public int? ВысотаБезСтупенькиРеновация { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ОбъемВнутреннегоСлоя { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ОбъемНаружногоСлоя { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ОбъемУтеплителя { get; set; }

        public int? ТолщинаВнутреннегоСлоя { get; set; }

        public int? ТолщинаНаружногоСлоя { get; set; }

        public int? ТолщинаУтеплителя { get; set; }

        public Guid? UUID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created_date { get; set; }

        [StringLength(255)]
        public string Responsible_person { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? moved_to_NPCon { get; set; }

        public int? id_object { get; set; }

        public int? id_mdm { get; set; }

        public int? id_end_prod_ver { get; set; }

        [StringLength(100)]
        public string Item_group_MDM { get; set; }

        public string comment { get; set; }

        public int? t_a { get; set; }
    }
}
