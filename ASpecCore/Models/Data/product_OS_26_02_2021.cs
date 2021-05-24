namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product_OS_26_02_2021
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_prod { get; set; }

        public int? id_mdm { get; set; }

        [StringLength(50)]
        public string listnum_prod { get; set; }

        public int? id_album_prod { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string blkname { get; set; }

        [StringLength(250)]
        public string nrm_unicname_trim { get; set; }

        public int? prodlength { get; set; }

        public int? prodheight { get; set; }

        public string file_path { get; set; }

        public byte[] prodpreview { get; set; }

        public int? prod_thickness { get; set; }

        public bool? outdoor { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid guid { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime updated_at { get; set; }

        public decimal? prod_weight { get; set; }

        public int? height_full { get; set; }

        public int? id_work_file { get; set; }

        public int? length_full { get; set; }

        public int? thickness_full { get; set; }

        public int? rotate_layers { get; set; }

        public bool? buying_part { get; set; }

        public decimal? volume { get; set; }

        public bool? renovation { get; set; }

        public bool? copy_mdm { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? chkd_URK { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? chkd_KTD { get; set; }

        public bool? archive { get; set; }

        public decimal? product_area_1С { get; set; }

        public decimal? Weight_1С { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool copy_1C { get; set; }
    }
}
