namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.projects")]
    public partial class projects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public projects()
        {
            sections = new HashSet<sections>();
        }

        [Key]
        public Guid UID_projects { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string code { get; set; }

        public int? ProjectId { get; set; }

        public bool Deleted_Projects { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Data_Time { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        public virtual Objects Objects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sections> sections { get; set; }
    }
}
