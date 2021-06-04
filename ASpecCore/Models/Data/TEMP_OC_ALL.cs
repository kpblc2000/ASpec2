namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMP_OC_ALL
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string тип { get; set; }

        [Column("тип норм.док.")]
        [StringLength(50)]
        public string тип_норм_док_ { get; set; }

        [Column("имя норм. док")]
        [StringLength(50)]
        public string имя_норм__док { get; set; }

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

        [Key]
        [Column("id суб.объекта", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_суб_объекта { get; set; }

        [Key]
        [Column("тип суб.об.", Order = 4)]
        [StringLength(50)]
        public string тип_суб_об_ { get; set; }

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
    }
}
