namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("objectmark")]
    public partial class objectmark
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public objectmark()
        {
            objectconsist = new HashSet<objectconsist>();
        }

        [Key]
        public int id_mark { get; set; }

        [Required]
        [StringLength(50)]
        public string markname { get; set; }

        public int id_type { get; set; }

        public int? id_normdoc_mark { get; set; }

        public virtual mark_type mark_type { get; set; }

        public virtual normdoc normdoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<objectconsist> objectconsist { get; set; }
    }
}
