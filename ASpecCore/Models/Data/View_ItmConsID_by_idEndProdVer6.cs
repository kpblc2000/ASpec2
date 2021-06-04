namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_ItmConsID_by_idEndProdVer6
    {
        public int? id_endprod_ver { get; set; }

        public decimal? end_prod_volume { get; set; }

        public decimal? end_prod_weight { get; set; }

        public decimal? end_prod_area { get; set; }

        public decimal? count_ropes { get; set; }

        public int? Item_construction_id { get; set; }

        public string Hand_mark_no_colour { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string blkname { get; set; }

        public int? Item_group_id { get; set; }

        public int? prodlength { get; set; }

        public int? prodheight { get; set; }

        public int? prod_thickness { get; set; }

        public int? height_full { get; set; }

        public int? length_full { get; set; }

        public int? thickness_full { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_prod { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_npcon_changes { get; set; }

        public bool? id_existance { get; set; }

        public int? ConcrVolBtn_IN_ID { get; set; }

        public decimal? ConcrVolBtn_IN_vol { get; set; }

        [StringLength(4000)]
        public string ОбъемВнутреннегоСлоя { get; set; }

        public int? ConcrVolBtn_ID { get; set; }

        public decimal? ConcrVolBtn_vol { get; set; }

        public int? ConcrVolBtn_FrontSide_ID { get; set; }

        public decimal? ConcrVolBtn_FrontSide_vol { get; set; }

        public int? ConcrVolBtn_UpperEndFace_ID { get; set; }

        public decimal? ConcrVolBtn_UpperEndFace_vol { get; set; }

        [StringLength(4000)]
        public string ОбъемНаружногоСлоя { get; set; }

        [StringLength(4000)]
        public string ОбъемУтеплителя { get; set; }

        [StringLength(4000)]
        public string ВысотаБезСтупенькиРеновация { get; set; }

        [StringLength(4000)]
        public string ТолщинаНаружногоСлоя { get; set; }

        [StringLength(4000)]
        public string ТолщинаВнутреннегоСлоя { get; set; }

        [StringLength(4000)]
        public string ТолщинаУтеплителя { get; set; }

        public bool? chk_KTD { get; set; }

        public int? id_line { get; set; }

        public int? id_tskmng_item { get; set; }
    }
}
