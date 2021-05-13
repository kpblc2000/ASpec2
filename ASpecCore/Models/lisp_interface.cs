namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lisp_interface
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lisp_interface()
        {
            users = new HashSet<user>();
        }

        [Key]
        public int Id_interface { get; set; }

        [Required]
        [StringLength(50)]
        public string CuixName { get; set; }

        public bool IsDefault { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string flename { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> users { get; set; }
    }
}
