namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_EndPod_TotalDim
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_endprod_ver { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string blkname { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string формование { get; set; }

        [StringLength(50)]
        public string forming_lifting { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int изменение { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string статус { get; set; }

        public decimal? вес { get; set; }

        public decimal? объём { get; set; }

        public int? длина { get; set; }

        public int? высота { get; set; }

        public int? толщина { get; set; }

        [Column("толщина(габаритная)")]
        public int? толщина_габаритная_ { get; set; }

        [StringLength(50)]
        public string Альбом { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_prod { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "datetime2")]
        public DateTime created_at { get; set; }

        public Guid? itm_conFrm_guid { get; set; }
    }
}
