namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mod_param_value_pool
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mod_param_value_pool()
        {
            product_modification = new HashSet<product_modification>();
        }

        [Key]
        public int id_mod_param_value_pool { get; set; }

        public int id_modif { get; set; }

        public int id_param { get; set; }

        public int height { get; set; }

        public int width { get; set; }

        public int? thickness { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? createdate { get; set; }

        [StringLength(50)]
        public string created_original_login { get; set; }

        public virtual modification_parameter modification_parameter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product_modification> product_modification { get; set; }
    }
}
