namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.nomenclature_current")]
    public partial class nomenclature_current
    {
        [Key]
        public Guid UID { get; set; }

        public Guid UID_Geometry { get; set; }

        public Guid? UID_Parameters { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(2000)]
        public string Geometry_Compare { get; set; }

        [StringLength(2000)]
        public string Parameter_Compare { get; set; }

        public virtual Geometry Geometry { get; set; }

        public virtual Parameters Parameters { get; set; }
    }
}
