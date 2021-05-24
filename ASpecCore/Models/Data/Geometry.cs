namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.Geometry")]
    public partial class Geometry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Geometry()
        {
            nomenclature_all = new HashSet<nomenclature_all>();
            nomenclature_current = new HashSet<nomenclature_current>();
        }

        [Key]
        public Guid UID { get; set; }

        public string Geometry_Part { get; set; }

        [Required]
        [StringLength(1000)]
        public string Matrix_Assembly { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nomenclature_all> nomenclature_all { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nomenclature_current> nomenclature_current { get; set; }
    }
}
