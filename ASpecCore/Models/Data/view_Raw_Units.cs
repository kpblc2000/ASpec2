namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_Raw_Units
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string objecttypename { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string unitname { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string unitcode { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_objecttype { get; set; }
    }
}
