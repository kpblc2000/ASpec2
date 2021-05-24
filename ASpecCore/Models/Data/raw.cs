namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("raw")]
    public partial class raw
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public raw()
        {
            end_prod_ver_RawConsist = new HashSet<end_prod_ver_RawConsist>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_raw { get; set; }

        public decimal weight { get; set; }

        [Required]
        [StringLength(4)]
        public string weight_units { get; set; }

        [StringLength(250)]
        public string raw_blkname { get; set; }

        public string raw_file_path { get; set; }

        public virtual angle angle { get; set; }

        public virtual arm arm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<end_prod_ver_RawConsist> end_prod_ver_RawConsist { get; set; }

        public virtual fstn_element fstn_element { get; set; }

        public virtual galvanized_iron galvanized_iron { get; set; }

        public virtual m_box m_box { get; set; }

        public virtual p_concrete p_concrete { get; set; }

        public virtual p_hdpe p_hdpe { get; set; }

        public virtual p_object p_object { get; set; }

        public virtual p_PEfilm p_PEfilm { get; set; }

        public virtual p_units p_units { get; set; }

        public virtual strip strip { get; set; }

        public virtual spiral_hose spiral_hose { get; set; }

        public virtual tube tube { get; set; }

        public virtual wood wood { get; set; }
    }
}
