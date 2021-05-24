namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("report.RDS")]
    public partial class RD
    {
        [Key]
        [StringLength(255)]
        public string RDS_name { get; set; }

        [StringLength(255)]
        public string rds_param { get; set; }
    }
}
