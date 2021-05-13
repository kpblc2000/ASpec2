namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mdm_Layer_documents_state_actual_t
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string Documents { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Layer { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string Layer_description { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Visiblity { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Template { get; set; }
    }
}
