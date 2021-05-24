namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.tblSeries")]
    public partial class tblSery
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string SeriaName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(150)]
        public string CreateUser { get; set; }
    }
}
