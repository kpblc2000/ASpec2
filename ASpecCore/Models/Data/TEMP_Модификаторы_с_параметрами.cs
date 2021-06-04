namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMP_Модификаторы_с_параметрами
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_modif { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_param { get; set; }

        [StringLength(255)]
        public string Item_modification_code { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string param_name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? createdate { get; set; }

        [StringLength(50)]
        public string created_original_login { get; set; }
    }
}
