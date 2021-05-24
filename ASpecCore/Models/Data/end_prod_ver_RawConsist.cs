namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class end_prod_ver_RawConsist
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_endprod_ver { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_raw { get; set; }

        public decimal raw_count { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime created_at { get; set; }

        [Required]
        [StringLength(50)]
        public string creator_username { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string btn_groupname { get; set; }

        public virtual end_product_version end_product_version { get; set; }

        public virtual raw raw { get; set; }
    }
}
