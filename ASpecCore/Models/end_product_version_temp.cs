namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class end_product_version_temp
    {
        [Key]
        [Column(Order = 0)]
        public int id_endprod_ver { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int modification_num { get; set; }

        [StringLength(250)]
        public string modification_descr { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "datetime2")]
        public DateTime created_at { get; set; }

        [StringLength(50)]
        public string creator_username { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool eprod_actual { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ver_status { get; set; }

        public int? execution_ver { get; set; }

        public string eprod_file_path { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_eprod_album { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_end_prod { get; set; }

        public Guid? itm_conFrm_guid { get; set; }

        public decimal? end_prod_weight { get; set; }

        public decimal? end_prod_volume { get; set; }

        public Guid? formin_type_guid { get; set; }

        public int? id_workfile { get; set; }

        public int? id_prod_workfile { get; set; }

        public decimal? end_prod_area { get; set; }
    }
}
