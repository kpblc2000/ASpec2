namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_РазницаПараметров2
    {
        [StringLength(50)]
        public string creator_username { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string Hand_mark_no_colour { get; set; }

        [StringLength(50)]
        public string Weight { get; set; }

        public decimal? NPConWeight { get; set; }

        [StringLength(50)]
        public string Volume { get; set; }

        public decimal? NPConVolume { get; set; }

        [StringLength(50)]
        public string Length { get; set; }

        [Column("NPCon length")]
        public int? NPCon_length { get; set; }

        [StringLength(50)]
        public string Height { get; set; }

        [Column("NPCon height")]
        public int? NPCon_height { get; set; }

        [StringLength(50)]
        public string Thickness { get; set; }

        [Column("NPCon overall Thickness")]
        public int? NPCon_overall_Thickness { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        public decimal? NPCon_Area { get; set; }

        [Column("overall Thickness")]
        [StringLength(50)]
        public string overall_Thickness { get; set; }

        [Column("NPCon thickness")]
        public int? NPCon_thickness { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string статус { get; set; }
    }
}
