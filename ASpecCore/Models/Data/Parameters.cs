namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.Parameters")]
    public partial class Parameters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parameters()
        {
            nomenclature_current = new HashSet<nomenclature_current>();
            nomenclature_all = new HashSet<nomenclature_all>();
        }

        [Key]
        public Guid UID { get; set; }

        [Column("Parameters")]
        [Required]
        public string Parameters1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nomenclature_current> nomenclature_current { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nomenclature_all> nomenclature_all { get; set; }
    }
}
