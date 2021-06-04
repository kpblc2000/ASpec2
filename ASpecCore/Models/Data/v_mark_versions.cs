namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_mark_versions
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_версии_изделия { get; set; }

        public int? id_NPCon_изделия { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Дата_1с { get; set; }

        public int? id_типа_линии { get; set; }

        public int? id_NPCon_сост_номенкл { get; set; }

        [StringLength(200)]
        public string Название_составляющей { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal Кол_во_составляющих { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string Ед_изм { get; set; }

        [StringLength(20)]
        public string ДЗ_статус { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Тип_спецификации_англ { get; set; }

        [StringLength(1000)]
        public string Тип_спецификации_рус { get; set; }

        [StringLength(1000)]
        public string Доп_инфа { get; set; }

        [StringLength(19)]
        public string Представление_состава { get; set; }

        public int? id_раздела { get; set; }
    }
}
