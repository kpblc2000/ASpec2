namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Marks_and_modifications
    {
        [StringLength(255)]
        public string Status { get; set; }

        [Column("by modificators")]
        [StringLength(255)]
        public string by_modificators { get; set; }

        [Column("by apertures")]
        [StringLength(255)]
        public string by_apertures { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string necessity { get; set; }

        public string RMark { get; set; }

        [StringLength(255)]
        public string console { get; set; }

        [StringLength(255)]
        public string Tooth { get; set; }

        [StringLength(255)]
        public string Insulation { get; set; }

        [StringLength(255)]
        public string loop_release { get; set; }

        [StringLength(255)]
        public string backs { get; set; }

        [StringLength(255)]
        public string Author { get; set; }

        [StringLength(255)]
        public string type_of_aperture { get; set; }

        [StringLength(255)]
        public string brace { get; set; }

        public int? id_mdm { get; set; }

        public int? id_aperture { get; set; }

        [StringLength(255)]
        public string aperture_geometry { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? moved_to_mdm { get; set; }

        public int? update { get; set; }

        public Guid? UUID { get; set; }

        public string comment { get; set; }

        public int? t_a { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int actual { get; set; }

        [StringLength(255)]
        public string Responsible_person { get; set; }

        [StringLength(255)]
        public string type_of_insert { get; set; }
    }
}
