namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMP_СкобаЗакладная
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public Guid? guid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string тип { get; set; }

        [Column("ед.изм.")]
        [StringLength(50)]
        public string ед_изм_ { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string марка { get; set; }

        [Column("имя блока")]
        [StringLength(250)]
        public string имя_блока { get; set; }

        [StringLength(50)]
        public string лист { get; set; }

        [StringLength(50)]
        public string альбом { get; set; }

        [Key]
        [Column("id суб.объекта", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_суб_объекта { get; set; }

        [Key]
        [Column("тип суб.об.", Order = 4)]
        [StringLength(50)]
        public string тип_суб_об_ { get; set; }

        public byte? diam { get; set; }

        [StringLength(20)]
        public string method { get; set; }

        public short? strength { get; set; }

        [StringLength(5)]
        public string armproperty { get; set; }

        [Key]
        [Column("марка суб.объекта", Order = 5)]
        [StringLength(200)]
        public string марка_суб_объекта { get; set; }

        [Key]
        [Column("кол-во суб.об.", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int кол_во_суб_об_ { get; set; }

        [Key]
        [Column("длина суб.об.", Order = 7)]
        public decimal длина_суб_об_ { get; set; }

        [Column("вес за 1 ед.изм. суб.об.")]
        public decimal? вес_за_1_ед_изм__суб_об_ { get; set; }

        [Key]
        [Column("тип норм.док. суб.эл", Order = 8)]
        [StringLength(50)]
        public string тип_норм_док__суб_эл { get; set; }

        [Key]
        [Column("имя норм. док. суб.эл", Order = 9)]
        [StringLength(50)]
        public string имя_норм__док__суб_эл { get; set; }

        public short? width_полосы { get; set; }

        public byte? thickness_полосы { get; set; }

        public byte? smallwidth_уголка { get; set; }

        public byte? largewidth_уголка { get; set; }

        public decimal? thickness_уголка { get; set; }
    }
}
