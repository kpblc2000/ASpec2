namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class p_PEfilm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_PEfilm { get; set; }

        public decimal thick_PEfilm { get; set; }

        [Required]
        [StringLength(4)]
        public string thick_PEfilm_unit { get; set; }

        public virtual p_units p_units { get; set; }

        public virtual raw raw { get; set; }
    }
}
