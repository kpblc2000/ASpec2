namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.Part")]
    public partial class Part
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Part()
        {
            Assembly_structure = new HashSet<Assembly_structure>();
        }

        [Key]
        public Guid UID_Part { get; set; }

        [Required]
        public string Part_Geometry_LISP { get; set; }

        [Required]
        [StringLength(2000)]
        public string Part_Compare_LISP { get; set; }

        [Required]
        public string Part_Parameters_LISP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assembly_structure> Assembly_structure { get; set; }
    }
}
