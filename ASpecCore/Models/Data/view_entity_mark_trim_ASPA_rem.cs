namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_entity_mark_trim_ASPA_rem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(100)]
        public string Марка { get; set; }

        [StringLength(100)]
        public string Вид { get; set; }
    }
}
