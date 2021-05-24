namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("objecttype")]
    public partial class objecttype
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public objecttype()
        {
            modificationType4object_type = new HashSet<modificationType4object_type>();
            objectprefixes = new HashSet<objectprefix>();
            permission4type = new HashSet<permission4type>();
            permission4type1 = new HashSet<permission4type>();
            p_object = new HashSet<p_object>();
            allLayers = new HashSet<allLayer>();
        }

        [Key]
        public int id_objecttype { get; set; }

        public bool isproduct { get; set; }

        [Required]
        [StringLength(50)]
        public string objecttypename { get; set; }

        [StringLength(50)]
        public string typeShortName { get; set; }

        public bool? isendproduct { get; set; }

        public int? id_type4mark { get; set; }

        public Guid objtypguid { get; set; }

        [StringLength(4)]
        public string tbl_unit { get; set; }

        public virtual mark_type mark_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<modificationType4object_type> modificationType4object_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<objectprefix> objectprefixes { get; set; }

        public virtual p_units p_units { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<permission4type> permission4type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<permission4type> permission4type1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<p_object> p_object { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<allLayer> allLayers { get; set; }
    }
}
