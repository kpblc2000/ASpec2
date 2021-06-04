namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class p_concr_waterres
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public p_concr_waterres()
        {
            p_concrete = new HashSet<p_concrete>();
        }

        [Key]
        public int id_concr_waterres { get; set; }

        [Required]
        [StringLength(25)]
        public string waterres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<p_concrete> p_concrete { get; set; }
    }
}
