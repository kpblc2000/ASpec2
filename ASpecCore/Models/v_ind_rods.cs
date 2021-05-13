namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_ind_rods
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string ОС { get; set; }

        [StringLength(250)]
        public string ОС_блок_на_чертеже { get; set; }

        public bool? актуальность_ОС { get; set; }

        [StringLength(200)]
        public string Составляющее { get; set; }

        public int? Кол_во_составляющих { get; set; }

        public decimal? Длина_составляющего { get; set; }

        [StringLength(50)]
        public string unitname { get; set; }

        public byte? diam { get; set; }

        [StringLength(20)]
        public string method { get; set; }

        public short? strength { get; set; }

        [StringLength(5)]
        public string armproperty { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Марка_стали { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Фиксация { get; set; }

        public int? id_типа_ОС { get; set; }

        [StringLength(50)]
        public string Тип_ОС { get; set; }

        public long? row_ver { get; set; }

        [StringLength(4)]
        public string ИД_ед_изм { get; set; }

        public int? id_steelClass { get; set; }

        public string Имя_по_регламенту { get; set; }
    }
}
