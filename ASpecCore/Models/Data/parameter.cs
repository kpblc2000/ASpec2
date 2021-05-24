namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("parameter")]
    public partial class parameter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public parameter()
        {
            modification_parameter = new HashSet<modification_parameter>();
        }

        [Key]
        public int id_param { get; set; }

        [Required]
        [StringLength(100)]
        public string param_name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? createdate { get; set; }

        [StringLength(50)]
        public string created_original_login { get; set; }

        [StringLength(4)]
        public string param_units { get; set; }

        public int id_sql_param_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<modification_parameter> modification_parameter { get; set; }

        public virtual p_units p_units { get; set; }

        public virtual sql_data_type sql_data_type { get; set; }
    }
}
