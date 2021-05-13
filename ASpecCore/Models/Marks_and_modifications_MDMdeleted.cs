namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Marks_and_modifications_MDMdeleted
    {
        public int? Item_construction_modification_id { get; set; }

        public int? Item_construction_id { get; set; }

        public int? Item_modification_id { get; set; }

        public Guid? guid { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? updated_at { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int t_a { get; set; }
    }
}
