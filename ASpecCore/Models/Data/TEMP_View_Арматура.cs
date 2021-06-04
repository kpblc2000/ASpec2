namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMP_View_Арматура
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string тип { get; set; }

        [Key]
        [Column("ед.изм. объекта", Order = 2)]
        [StringLength(50)]
        public string ед_изм__объекта { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string марка { get; set; }

        [Key]
        [Column("вес за 1 ед.изм изделия", Order = 4)]
        public decimal вес_за_1_ед_изм_изделия { get; set; }

        [Key]
        [Column("ед.изм. веса", Order = 5)]
        [StringLength(50)]
        public string ед_изм__веса { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool согласовано { get; set; }

        [Column("дата согласования")]
        public DateTime? дата_согласования { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime создано { get; set; }

        [Key]
        [Column("кто создал", Order = 8)]
        [StringLength(50)]
        public string кто_создал { get; set; }

        [Column("тип норм.док.")]
        [StringLength(50)]
        public string тип_норм_док_ { get; set; }

        [Column("имя документа")]
        [StringLength(50)]
        public string имя_документа { get; set; }

        [Key]
        [Column(Order = 9)]
        public byte диаметр { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string метод { get; set; }

        public short? прочность { get; set; }

        [StringLength(5)]
        public string свойство { get; set; }
    }
}
