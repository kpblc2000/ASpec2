namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class p_hdpe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_hdpe { get; set; }

        public byte diam_hdpe { get; set; }

        [Required]
        [StringLength(5)]
        public string d_pref { get; set; }

        [Required]
        [StringLength(4)]
        public string diam_hdpe_unit { get; set; }

        public virtual p_units p_units { get; set; }

        public virtual raw raw { get; set; }
    }
}
