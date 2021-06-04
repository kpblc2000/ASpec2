namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("factory")]
    public partial class factory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public factory()
        {
            album = new HashSet<album>();
            factory_lines = new HashSet<factory_lines>();
        }

        [Key]
        public int id_fact { get; set; }

        [Required]
        [StringLength(255)]
        public string f_name { get; set; }

        [Required]
        [StringLength(50)]
        public string f_prefix { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<album> album { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factory_lines> factory_lines { get; set; }
    }
}
