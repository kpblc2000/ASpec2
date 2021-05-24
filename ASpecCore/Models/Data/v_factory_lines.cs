namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_factory_lines
    {
        public int? id_линии { get; set; }

        [StringLength(255)]
        public string Название_завода { get; set; }

        [StringLength(50)]
        public string Префикс_завода { get; set; }

        [StringLength(255)]
        public string Видформования { get; set; }

        [StringLength(50)]
        public string ВидКантования { get; set; }

        [StringLength(255)]
        public string ВидАрмирования { get; set; }

        [StringLength(255)]
        public string МаркаСтали { get; set; }

        [StringLength(255)]
        public string КлассБетона { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string CAD_Данные { get; set; }

        public bool? Актуальность_линии { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Актуальность_линии_на_заводе { get; set; }

        [StringLength(200)]
        public string Полное_наименование_линии { get; set; }
    }
}
