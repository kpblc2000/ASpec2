namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RCP.Colour_index")]
    public partial class Colour_index
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Colour_index()
        {
            RCP_nomenclature = new HashSet<RCP_nomenclature>();
        }

        [Key]
        public int id_col_index { get; set; }

        public int Item_colour_id { get; set; }

        [Required]
        [StringLength(500)]
        public string Item_colour { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RCP_nomenclature> RCP_nomenclature { get; set; }
    }
}
