namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cmd_log
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string UserLogin { get; set; }

        [StringLength(50)]
        public string UserDomain { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "datetime2")]
        public DateTime RecDateTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string NameCmd { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string NameFile { get; set; }

        [StringLength(100)]
        public string PC_name { get; set; }
    }
}
