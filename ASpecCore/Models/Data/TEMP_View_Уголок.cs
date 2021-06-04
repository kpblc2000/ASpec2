namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMP_View_Уголок
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
        [Column("большая ширина", Order = 4)]
        public byte большая_ширина { get; set; }

        [Key]
        [Column("меньшая ширина", Order = 5)]
        public byte меньшая_ширина { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal толщина { get; set; }

        [Key]
        [Column("вес за 1 ед.изм изделия", Order = 7)]
        public decimal вес_за_1_ед_изм_изделия { get; set; }

        [Key]
        [Column("ед.изм. веса", Order = 8)]
        [StringLength(50)]
        public string ед_изм__веса { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool согласовано { get; set; }

        [Column("дата согласования")]
        public DateTime? дата_согласования { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime создано { get; set; }

        [Key]
        [Column("кто создал", Order = 11)]
        [StringLength(50)]
        public string кто_создал { get; set; }

        [Key]
        [Column("тип норм.док.", Order = 12)]
        [StringLength(50)]
        public string тип_норм_док_ { get; set; }

        [Key]
        [Column("имя документа", Order = 13)]
        [StringLength(50)]
        public string имя_документа { get; set; }
    }
}
