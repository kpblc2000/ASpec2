namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Temp_PG_View_UnicEndProd
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string blkname { get; set; }

        public int? max_id_endprod_ver { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string objecttypename { get; set; }
    }
}
