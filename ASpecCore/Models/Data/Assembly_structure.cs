namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.Assembly_structure")]
    public partial class Assembly_structure
    {
        [Key]
        [Column(Order = 0)]
        public Guid UID_Assembly { get; set; }

        public Guid? UID_Part { get; set; }

        public Guid? UID_Assembly_Part { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Matrix_Assembly { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Number_Assembly_Part { get; set; }

        public virtual Assembly Assembly { get; set; }

        public virtual Assembly Assembly1 { get; set; }

        public virtual Part Part { get; set; }
    }
}
