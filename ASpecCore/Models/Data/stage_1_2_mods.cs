namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class stage_1_2_mods
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_prod { get; set; }

        public int? id_mdm { get; set; }

        [StringLength(200)]
        public string unicname_trim { get; set; }

        public int? Item_modification_ID { get; set; }

        [StringLength(255)]
        public string Модификатор { get; set; }

        [StringLength(100)]
        public string Параметр { get; set; }

        [StringLength(4000)]
        public string Значение { get; set; }
    }
}
