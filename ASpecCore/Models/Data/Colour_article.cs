namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RCP.Colour_article")]
    public partial class Colour_article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Colour_article()
        {
            RCP_consistancy = new HashSet<RCP_consistancy>();
        }

        [Key]
        public int id_col_art { get; set; }

        [Required]
        [StringLength(500)]
        public string article { get; set; }

        public int? facing_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? length { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? height { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? thickness { get; set; }

        public string colour_name { get; set; }

        public string manufactor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RCP_consistancy> RCP_consistancy { get; set; }
    }
}
