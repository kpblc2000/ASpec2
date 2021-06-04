namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Heater_correct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int file_ver { get; set; }

        [StringLength(1000)]
        public string heater_name { get; set; }

        public decimal? dwg_volume { get; set; }
    }
}
