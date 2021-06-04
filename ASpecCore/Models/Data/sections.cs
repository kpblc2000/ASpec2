namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.sections")]
    public partial class sections
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sections()
        {
            floors = new HashSet<floors>();
        }

        [Key]
        public Guid UID_sections { get; set; }

        public Guid UID_projects { get; set; }

        [Required]
        [StringLength(250)]
        public string Name_sections { get; set; }

        public bool Deleted_Sections { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Data_Time { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<floors> floors { get; set; }

        public virtual projects projects { get; set; }
    }
}
