namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblNodesContent")]
    public partial class tblNodesContent
    {
        [Key]
        public Guid uid { get; set; }

        public int AlbumId { get; set; }

        [Required]
        [StringLength(50)]
        public string NodeName { get; set; }

        [StringLength(50)]
        public string NodeSheet { get; set; }

        [Required]
        public string Handles { get; set; }

        public double MinX { get; set; }

        public double MinY { get; set; }

        public double MaxX { get; set; }

        public double MaxY { get; set; }

        public double BaseScale { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(200)]
        public string CreateLogin { get; set; }

        public bool Actual { get; set; }

        public virtual album album { get; set; }
    }
}
