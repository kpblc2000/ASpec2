namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cmd_userlogins
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cmd_userlogins()
        {
            cmd_user_lisp = new HashSet<cmd_user_lisp>();
            cmd_groups = new HashSet<cmd_groups>();
        }

        [Key]
        public int id_userlogin { get; set; }

        public int id_user { get; set; }

        public int id_domain { get; set; }

        public bool actual { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cmd_user_lisp> cmd_user_lisp { get; set; }

        public virtual cmd_userdomains cmd_userdomains { get; set; }

        public virtual cmd_users cmd_users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cmd_groups> cmd_groups { get; set; }
    }
}
