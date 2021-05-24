namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.KZI_Name")]
    public partial class KZI_Name
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KZI_Name()
        {
            KZIs = new HashSet<KZI>();
            nomenclatures = new HashSet<nomenclature>();
        }

        [Key]
        public Guid UID_KZI_Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Name_KZI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KZI> KZIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nomenclature> nomenclatures { get; set; }
    }
}
