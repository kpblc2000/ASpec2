namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("classType")]
    public partial class classType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public classType()
        {
            work_file = new HashSet<work_file>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idClass { get; set; }

        [Required]
        [StringLength(250)]
        public string className { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<work_file> work_file { get; set; }
    }
}
