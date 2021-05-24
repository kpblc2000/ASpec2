namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_ktd_heater_3d
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string blkname { get; set; }

        public int? prodlength { get; set; }

        public int? prodheight { get; set; }

        public int? prod_thickness { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string objecttypename { get; set; }
    }
}
