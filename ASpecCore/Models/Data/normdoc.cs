namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("normdoc")]
    public partial class normdoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public normdoc()
        {
            objectmark = new HashSet<objectmark>();
            p_object = new HashSet<p_object>();
        }

        [Key]
        public int id_normdoc { get; set; }

        [Required]
        [StringLength(50)]
        public string doctype { get; set; }

        [Required]
        [StringLength(50)]
        public string doccode { get; set; }

        [Required]
        [StringLength(250)]
        public string description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<objectmark> objectmark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<p_object> p_object { get; set; }
    }
}
