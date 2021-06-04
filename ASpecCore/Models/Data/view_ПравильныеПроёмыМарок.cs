namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_ПравильныеПроёмыМарок
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        public int? id_mdm { get; set; }

        [StringLength(50)]
        public string P_Mark { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string RightMark { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string p_t { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string p_h { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string p_b { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int P_count { get; set; }
    }
}
