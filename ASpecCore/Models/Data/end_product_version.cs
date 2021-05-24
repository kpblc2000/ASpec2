namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class end_product_version
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public end_product_version()
        {
            end_prod_ver_RawConsist = new HashSet<end_prod_ver_RawConsist>();
        }

        [Key]
        public int id_endprod_ver { get; set; }

        public int modification_num { get; set; }

        [StringLength(250)]
        public string modification_descr { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime created_at { get; set; }

        [StringLength(50)]
        public string creator_username { get; set; }

        public bool eprod_actual { get; set; }

        public int ver_status { get; set; }

        public int? execution_ver { get; set; }

        public string eprod_file_path { get; set; }

        public int id_eprod_album { get; set; }

        public int id_end_prod { get; set; }

        public Guid? itm_conFrm_guid { get; set; }

        public decimal? end_prod_weight { get; set; }

        public decimal? end_prod_volume { get; set; }

        public Guid? formin_type_guid { get; set; }

        public int? id_workfile { get; set; }

        public int? id_prod_workfile { get; set; }

        public decimal? end_prod_area { get; set; }

        public int? prodlength { get; set; }

        public int? prodheight { get; set; }

        public int? prod_thickness { get; set; }

        public int? id_tskmng_item { get; set; }

        public int? id_line { get; set; }

        public int? id_rep_pod { get; set; }

        public bool chk_KTD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<end_prod_ver_RawConsist> end_prod_ver_RawConsist { get; set; }

        public virtual Line Line { get; set; }

        public virtual prod_work_file prod_work_file { get; set; }

        public virtual product product { get; set; }

        public virtual version_status version_status { get; set; }
    }
}
