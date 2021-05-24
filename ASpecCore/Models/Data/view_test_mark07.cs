namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_test_mark07
    {
        public int? id_obj { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(220)]
        public string mark { get; set; }

        public int? thickness_full { get; set; }

        [StringLength(50)]
        public string objecttypename { get; set; }

        [StringLength(255)]
        public string Item_modification_code { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column("Расчётное значение")]
        public int? Расчётное_значение { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string created_original_login { get; set; }

        public bool? modif_exist { get; set; }

        [StringLength(4000)]
        public string modif_param_value { get; set; }

        public int? id_objecttype { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_modif { get; set; }
    }
}
