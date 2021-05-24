namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class p_units
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public p_units()
        {
            end_prod_ver_consist = new HashSet<end_prod_ver_consist>();
            objectconsists = new HashSet<objectconsist>();
            objecttypes = new HashSet<objecttype>();
            p_hdpe = new HashSet<p_hdpe>();
            p_object = new HashSet<p_object>();
            p_PEfilm = new HashSet<p_PEfilm>();
            parameters = new HashSet<parameter>();
            raws = new HashSet<raw>();
        }

        [Key]
        [StringLength(4)]
        public string unitcode { get; set; }

        [Required]
        [StringLength(50)]
        public string unitname { get; set; }

        [Required]
        [StringLength(50)]
        public string graphsymbol_rus { get; set; }

        [StringLength(50)]
        public string graphsymbol_int { get; set; }

        [Required]
        [StringLength(50)]
        public string codesymbol_rus { get; set; }

        [StringLength(50)]
        public string codesymbol_int { get; set; }

        [StringLength(50)]
        public string p_quantity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<end_prod_ver_consist> end_prod_ver_consist { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<objectconsist> objectconsists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<objecttype> objecttypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<p_hdpe> p_hdpe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<p_object> p_object { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<p_PEfilm> p_PEfilm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<parameter> parameters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<raw> raws { get; set; }
    }
}
