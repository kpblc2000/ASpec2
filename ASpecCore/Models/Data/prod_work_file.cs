namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prod_work_file
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public prod_work_file()
        {
            end_product_version = new HashSet<end_product_version>();
        }

        [Key]
        public int id_prod_work { get; set; }

        public int id_obj_prod { get; set; }

        public int id_workfile { get; set; }

        public int work_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<end_product_version> end_product_version { get; set; }

        public virtual product product { get; set; }

        public virtual work_file work_file { get; set; }

        public virtual wrk_file_type wrk_file_type { get; set; }
    }
}
