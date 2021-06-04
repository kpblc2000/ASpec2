namespace ASpecCore.Models.Data
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
            tblNodeDepth = new HashSet<tblNodeDepth>();
            tblNodesContent = new HashSet<tblNodesContent>();
            listalb = new HashSet<listalb>();
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
        public virtual ICollection<tblNodeDepth> tblNodeDepth { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNodesContent> tblNodesContent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<listalb> listalb { get; set; }
    }
}
