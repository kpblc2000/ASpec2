namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.nomenclature")]
    public partial class nomenclature
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nomenclature()
        {
            project_specific = new HashSet<project_specific>();
        }

        [Key]
        public Guid UID_nomenclature { get; set; }

        [StringLength(250)]
        public string Nomenclature_type { get; set; }

        public Guid UID_KZI_Name { get; set; }

        public Guid? UID_Color { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Data_Time { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        public virtual color color { get; set; }

        public virtual KZI_Name KZI_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<project_specific> project_specific { get; set; }
    }
}
