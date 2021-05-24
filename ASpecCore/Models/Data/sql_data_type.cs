namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sql_data_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sql_data_type()
        {
            parameters = new HashSet<parameter>();
        }

        [Key]
        public int id_sql_param_type { get; set; }

        [Required]
        [StringLength(50)]
        public string sql_param_type_name { get; set; }

        [StringLength(450)]
        public string type_descr { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? createdate { get; set; }

        [StringLength(50)]
        public string created_original_login { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<parameter> parameters { get; set; }
    }
}
