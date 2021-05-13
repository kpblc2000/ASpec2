namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wrk_file_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wrk_file_type()
        {
            prod_work_file = new HashSet<prod_work_file>();
        }

        [Key]
        public int id_file_type { get; set; }

        [Required]
        [StringLength(50)]
        public string file_type { get; set; }

        [Required]
        [StringLength(250)]
        public string file_type_desc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prod_work_file> prod_work_file { get; set; }
    }
}
