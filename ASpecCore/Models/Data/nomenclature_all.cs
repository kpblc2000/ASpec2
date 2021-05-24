namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.nomenclature_all")]
    public partial class nomenclature_all
    {
        [Key]
        [Column(Order = 0)]
        public Guid UID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UID_Geometry { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid UID_Parameters { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(250)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2000)]
        public string Geometry_Compare { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2000)]
        public string Parameter_Compare { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Version { get; set; }

        public virtual Geometry Geometry { get; set; }

        public virtual Parameter1 Parameter { get; set; }
    }
}
