namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_Item_construction_modification_list_C1P
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string КЖИ { get; set; }

        [StringLength(5)]
        public string Модификация { get; set; }

        [Column("Тип модификации")]
        [StringLength(50)]
        public string Тип_модификации { get; set; }

        [StringLength(10)]
        public string Сторона { get; set; }

        [Column("Размер модификации")]
        public int? Размер_модификации { get; set; }

        [Column("Классификатор сокращений")]
        [StringLength(15)]
        public string Классификатор_сокращений { get; set; }

        [Column("Схема работы")]
        [StringLength(50)]
        public string Схема_работы { get; set; }

        [Column("Количество слоев")]
        [StringLength(50)]
        public string Количество_слоев { get; set; }

        [Column("Количество сторон опирания")]
        public int? Количество_сторон_опирания { get; set; }

        [Key]
        [Column("Идентификатор КЖИ", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Идентификатор_КЖИ { get; set; }

        [Column("Идентификатор модификации КЖИ")]
        public int? Идентификатор_модификации_КЖИ { get; set; }

        [Column("Идентификатор модификации")]
        public int? Идентификатор_модификации { get; set; }

        [Column("Идентификатор типа модификации")]
        public int? Идентификатор_типа_модификации { get; set; }

        public int? Порядок { get; set; }
    }
}
