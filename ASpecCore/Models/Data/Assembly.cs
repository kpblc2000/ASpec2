namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.Assembly")]
    public partial class Assembly
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Assembly()
        {
            Assembly_structure = new HashSet<Assembly_structure>();
            Assembly_structure1 = new HashSet<Assembly_structure>();
            KZIs = new HashSet<KZI>();
        }

        [Key]
        public Guid UID_Assembly { get; set; }

        [Required]
        [StringLength(2000)]
        public string Assembly_Compare_LISP { get; set; }

        [Required]
        public string Assembly_Parameters_LISP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assembly_structure> Assembly_structure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assembly_structure> Assembly_structure1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KZI> KZIs { get; set; }
    }
}
