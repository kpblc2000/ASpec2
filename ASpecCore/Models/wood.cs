namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("wood")]
    public partial class wood
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_wood { get; set; }

        public short width_wd { get; set; }

        public byte thickness_wd { get; set; }

        public virtual raw raw { get; set; }
    }
}
