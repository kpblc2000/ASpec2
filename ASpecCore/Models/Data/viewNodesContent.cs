namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("viewNodesContent")]
    public partial class viewNodesContent
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_album { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string name_alb { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string description_alb { get; set; }

        public string file_path { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid uid { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string NodeName { get; set; }

        [StringLength(50)]
        public string NodeSheet { get; set; }

        [Key]
        [Column(Order = 5)]
        public string Handles { get; set; }

        [Key]
        [Column(Order = 6)]
        public double MinX { get; set; }

        [Key]
        [Column(Order = 7)]
        public double MinY { get; set; }

        [Key]
        [Column(Order = 8)]
        public double MaxX { get; set; }

        [Key]
        [Column(Order = 9)]
        public double MaxY { get; set; }

        [Key]
        [Column(Order = 10)]
        public double scale { get; set; }
    }
}
