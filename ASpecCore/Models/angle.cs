namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("angle")]
    public partial class angle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_angle { get; set; }

        public byte largewidth { get; set; }

        public byte smallwidth { get; set; }

        public decimal thickness { get; set; }

        [StringLength(1)]
        public string precision { get; set; }

        public virtual raw raw { get; set; }
    }
}
