namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class aspa_entity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(100)]
        public string title { get; set; }

        public int? eid { get; set; }

        public int? gid { get; set; }

        [StringLength(1000)]
        public string description { get; set; }

        [StringLength(36)]
        public string uuid { get; set; }
    }
}
