namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tube")]
    public partial class tube
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_tube { get; set; }

        public decimal diam { get; set; }

        public decimal thickness { get; set; }

        public int id_normdoc_tube { get; set; }

        public virtual raw raw { get; set; }
    }
}
