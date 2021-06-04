namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMP_View_Утеплитель
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string марка { get; set; }

        [Key]
        [Column("имя блока", Order = 2)]
        [StringLength(250)]
        public string имя_блока { get; set; }

        public int? длина { get; set; }

        public int? высота { get; set; }

        public int? толщина { get; set; }

        [Key]
        [Column("тип объекта", Order = 3)]
        [StringLength(50)]
        public string тип_объекта { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool продукт { get; set; }

        [Column("конечный продукт")]
        public bool? конечный_продукт { get; set; }
    }
}
