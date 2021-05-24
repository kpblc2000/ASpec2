namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("allLayer")]
    public partial class allLayer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public allLayer()
        {
            objecttypes = new HashSet<objecttype>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Layer { get; set; }

        [Required]
        [StringLength(250)]
        public string LayerName { get; set; }

        public bool? IsOff { get; set; }

        public bool? IsFrozen { get; set; }

        public bool? IsLocked { get; set; }

        public short Color { get; set; }

        [Required]
        [StringLength(50)]
        public string LineType { get; set; }

        public int LineWeight { get; set; }

        public bool IsPlottable { get; set; }

        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<objecttype> objecttypes { get; set; }
    }
}
