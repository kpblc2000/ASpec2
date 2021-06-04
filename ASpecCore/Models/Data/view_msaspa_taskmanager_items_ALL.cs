namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_msaspa_taskmanager_items_ALL
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(20)]
        public string factory { get; set; }

        [StringLength(10)]
        public string forming_type { get; set; }

        [StringLength(10)]
        public string revision { get; set; }

        [StringLength(20)]
        public string state { get; set; }

        public int? id_obj { get; set; }

        public int? id_endprod_ver { get; set; }

        public int? id_line { get; set; }
    }
}
