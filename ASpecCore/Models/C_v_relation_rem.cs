namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_v_relation_rem")]
    public partial class C_v_relation_rem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? eid { get; set; }

        public int? gid { get; set; }

        [StringLength(1000)]
        public string description { get; set; }
    }
}
