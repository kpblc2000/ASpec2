namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class factory_lines
    {
        [Key]
        public int id_fact_line { get; set; }

        public int id_fact { get; set; }

        public int id_line { get; set; }

        public bool actual { get; set; }

        public virtual factory factory { get; set; }

        public virtual Line Line { get; set; }
    }
}
