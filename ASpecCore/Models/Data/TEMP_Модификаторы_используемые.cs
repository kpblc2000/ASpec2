namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMP_Модификаторы_используемые
    {
        [StringLength(255)]
        public string Item_modification_code { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_modif { get; set; }

        public int? Item_modification_id { get; set; }

        public int? type_input { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool is_single { get; set; }

        public int? proof_KB { get; set; }
    }
}
