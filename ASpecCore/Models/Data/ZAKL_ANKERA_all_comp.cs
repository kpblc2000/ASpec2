namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ZAKL_ANKERA_all_comp
    {
        [Key]
        [Column("Наим. изделия (вар.1)")]
        [StringLength(200)]
        public string Наим__изделия__вар_1_ { get; set; }

        [Column("Наим. изделия (вар.2)")]
        [StringLength(250)]
        public string Наим__изделия__вар_2_ { get; set; }

        [StringLength(200)]
        public string Закладная { get; set; }

        [Column("Кол-во закладных в КЖИ")]
        public int? Кол_во_закладных_в_КЖИ { get; set; }

        [Column("Марка составляющей")]
        [StringLength(200)]
        public string Марка_составляющей { get; set; }

        [Column("Вид составляющей")]
        [StringLength(50)]
        public string Вид_составляющей { get; set; }

        [Column("Измеритель составляющей")]
        public decimal? Измеритель_составляющей { get; set; }

        [Column("Ед. измерения")]
        [StringLength(50)]
        public string Ед__измерения { get; set; }

        [Column("Кол-во составляющих в закладной")]
        public int? Кол_во_составляющих_в_закладной { get; set; }

        [Column("Кол-во составляющих в изделии")]
        public int? Кол_во_составляющих_в_изделии { get; set; }
    }
}
