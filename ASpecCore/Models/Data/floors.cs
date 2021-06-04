namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.floors")]
    public partial class floors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public floors()
        {
            project_specific = new HashSet<project_specific>();
        }

        [Key]
        public Guid UID_floors { get; set; }

        public Guid UID_sections { get; set; }

        [Required]
        [StringLength(250)]
        public string Name_floors { get; set; }

        public Guid UID_FILE { get; set; }

        public bool Deleted_Floors { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Data_Time { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        public virtual sections sections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<project_specific> project_specific { get; set; }
    }
}
