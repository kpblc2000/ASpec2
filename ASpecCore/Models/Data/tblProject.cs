namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.tblProjects")]
    public partial class tblProject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProject()
        {
            tblModificators_OLD = new HashSet<tblModificators_OLD>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string ProjectNumber { get; set; }

        [StringLength(200)]
        public string BuildType { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(150)]
        public string CreateUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblModificators_OLD> tblModificators_OLD { get; set; }
    }
}
