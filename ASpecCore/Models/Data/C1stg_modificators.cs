namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("report.1stg_modificators")]
    public partial class C1stg_modificators
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_modification_id { get; set; }

        [StringLength(5)]
        public string Item_modification_code { get; set; }

        [StringLength(50)]
        public string NPCon_mod { get; set; }

        [StringLength(50)]
        public string Robot_mod { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
