namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logging.tbl_UserActivityStat")]
    public partial class tbl_UserActivityStat
    {
        [Key]
        public Guid id_log { get; set; }

        [Required]
        [StringLength(100)]
        public string UserLogin { get; set; }

        [Required]
        [StringLength(100)]
        public string CompName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime StartACAD { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EndACAD { get; set; }

        public int FullTimeWork { get; set; }
    }
}
