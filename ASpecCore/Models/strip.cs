namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("strip")]
    public partial class strip
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_strip { get; set; }

        public short width { get; set; }

        public byte thickness { get; set; }

        public virtual raw raw { get; set; }
    }
}
