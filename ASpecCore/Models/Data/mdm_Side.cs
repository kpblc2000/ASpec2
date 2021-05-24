namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mdm_Side
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Side_id { get; set; }

        public int? Side_id_access { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Side { get; set; }

        [Key]
        [Column(Order = 2)]
        public int id_side { get; set; }
    }
}
