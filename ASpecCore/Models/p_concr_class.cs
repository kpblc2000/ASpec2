namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class p_concr_class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public p_concr_class()
        {
            p_concrete = new HashSet<p_concrete>();
        }

        [Key]
        public int id_concr_class { get; set; }

        [Required]
        [StringLength(25)]
        public string c_classname { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? c_val { get; set; }

        [StringLength(255)]
        public string c_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<p_concrete> p_concrete { get; set; }
    }
}
