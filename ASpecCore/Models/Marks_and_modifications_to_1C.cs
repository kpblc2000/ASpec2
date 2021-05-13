namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Marks_and_modifications_to_1C
    {
        [Key]
        [Column(Order = 0)]
        public string marks { get; set; }

        [Key]
        [Column(Order = 1)]
        public string modification { get; set; }

        public int? ID_marks { get; set; }

        public int? ID_groups { get; set; }

        public int? ID_modificators { get; set; }

        public int? ID_modificators_gr { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid UUID { get; set; }

        public int? t_a { get; set; }

        [StringLength(255)]
        public string Responsible_person { get; set; }

        [StringLength(255)]
        public string type_of_insert { get; set; }

        public int? id_object_nm { get; set; }

        public int? id_modif_nm { get; set; }
    }
}
