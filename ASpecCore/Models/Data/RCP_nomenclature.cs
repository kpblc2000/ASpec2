namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RCP.RCP_nomenclature")]
    public partial class RCP_nomenclature
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RCP_nomenclature()
        {
            RCP_consistancy = new HashSet<RCP_consistancy>();
        }

        [Key]
        public int id_RCP { get; set; }

        public int id_obj { get; set; }

        public int id_col_index { get; set; }

        public virtual p_object p_object { get; set; }

        public virtual Colour_index Colour_index { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RCP_consistancy> RCP_consistancy { get; set; }
    }
}
