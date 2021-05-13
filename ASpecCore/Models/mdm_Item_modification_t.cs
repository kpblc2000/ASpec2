namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mdm_Item_modification_t
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mdm_Item_modification_t()
        {
            modification_parameter = new HashSet<modification_parameter>();
            modificationType4object_type = new HashSet<modificationType4object_type>();
        }

        [Key]
        public int id_modif { get; set; }

        public int? Item_modification_id { get; set; }

        public int? Item_modification_id_access { get; set; }

        [StringLength(255)]
        public string Item_modification_code { get; set; }

        public int? Item_modification_type_id { get; set; }

        public int? Side_id { get; set; }

        public int? Item_modification_point { get; set; }

        public int? Item_modification_measure { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int? type_input { get; set; }

        public int? proof_KB { get; set; }

        public bool is_single { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<modification_parameter> modification_parameter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<modificationType4object_type> modificationType4object_type { get; set; }
    }
}
