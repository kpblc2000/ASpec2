namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_EndPod_TotalDim_2ASPA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string Марка { get; set; }

        [StringLength(50)]
        public string Альбом { get; set; }

        [Key]
        [Column("№ изделия", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C__изделия { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int изменение { get; set; }

        [Key]
        [Column("№ версии", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C__версии { get; set; }

        [Column("№ МДМ")]
        public int? C__МДМ { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string формование { get; set; }

        [StringLength(50)]
        public string кантователь { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string статус { get; set; }

        [Column("вес изделия т.")]
        public decimal? вес_изделия_т_ { get; set; }

        [Column("вес металла кг.")]
        public decimal? вес_металла_кг_ { get; set; }

        public decimal? объём { get; set; }

        public int? длина { get; set; }

        public int? высота { get; set; }

        public int? толщина { get; set; }

        [Column("толщина(габаритная)")]
        public int? толщина_габаритная_ { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "datetime2")]
        public DateTime created_at { get; set; }

        [Column("макс дата", TypeName = "datetime2")]
        public DateTime? макс_дата { get; set; }
    }
}
