namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("user")]
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            lisp_interface = new HashSet<lisp_interface>();
        }

        [Key]
        public int Id_user { get; set; }

        [Required]
        [StringLength(50)]
        public string UserLogin { get; set; }

        [StringLength(50)]
        public string UserDomain { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lisp_interface> lisp_interface { get; set; }
    }
}
