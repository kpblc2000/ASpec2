namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cmd_lisp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cmd_lisp()
        {
            cmd_alias = new HashSet<cmd_alias>();
            cmd_user_lisp = new HashSet<cmd_user_lisp>();
            cmd_groups = new HashSet<cmd_groups>();
        }

        [Key]
        public int id_lisp { get; set; }

        [Required]
        [StringLength(250)]
        public string lisp { get; set; }

        public string description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cmd_alias> cmd_alias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cmd_user_lisp> cmd_user_lisp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cmd_groups> cmd_groups { get; set; }
    }
}
