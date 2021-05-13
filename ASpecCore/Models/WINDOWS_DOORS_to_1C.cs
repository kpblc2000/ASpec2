namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WINDOWS_DOORS_to_1C
    {
        public int? id_mdm { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_proem { get; set; }

        public int? t_a { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int actual { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string mark { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string aperture_geomerty { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string type_of_aperture { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid UUID { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "datetime2")]
        public DateTime created_by { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? moved_to_1c { get; set; }

        [StringLength(255)]
        public string Responsible_person { get; set; }
    }
}
