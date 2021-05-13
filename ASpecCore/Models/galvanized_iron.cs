namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class galvanized_iron
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_galvanized_iron { get; set; }

        public decimal thickness { get; set; }

        public short width { get; set; }

        public virtual raw raw { get; set; }
    }
}
