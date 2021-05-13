namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("album")]
    public partial class album
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public album()
        {
            tblNodeDepths = new HashSet<tblNodeDepth>();
            tblNodesContents = new HashSet<tblNodesContent>();
            listalbs = new HashSet<listalb>();
        }

        [Key]
        public int id_album { get; set; }

        [Required]
        [StringLength(50)]
        public string name_alb { get; set; }

        [Required]
        [StringLength(250)]
        public string description_alb { get; set; }

        public bool? in_design { get; set; }

        [StringLength(50)]
        public string compr_name { get; set; }

        [StringLength(50)]
        public string created_alb_orig_login { get; set; }

        public string file_path { get; set; }

        public bool? is_end_prod_alb { get; set; }

        public int? id_fact { get; set; }

        public virtual factory factory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNodeDepth> tblNodeDepths { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNodesContent> tblNodesContents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<listalb> listalbs { get; set; }
    }
}
