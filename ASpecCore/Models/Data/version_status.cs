namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class version_status
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public version_status()
        {
            end_product_version = new HashSet<end_product_version>();
        }

        [Key]
        public int id_status { get; set; }

        [Required]
        [StringLength(50)]
        public string status_name { get; set; }

        [StringLength(250)]
        public string status_descr { get; set; }

        public int status_priority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<end_product_version> end_product_version { get; set; }
    }
}
