namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logging.tbl_AspecificErrorLog")]
    public partial class tbl_AspecificErrorLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_err { get; set; }

        [StringLength(4000)]
        public string e_Message { get; set; }

        [StringLength(4000)]
        public string e_StackTrace { get; set; }

        [StringLength(4000)]
        public string e_InnerException { get; set; }

        [StringLength(4000)]
        public string e_Source { get; set; }

        [StringLength(4000)]
        public string e_TargetSite { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? log_Date { get; set; }

        [StringLength(50)]
        public string created_original_login { get; set; }

        [StringLength(500)]
        public string dwg_name { get; set; }

        public bool? in_work { get; set; }

        public bool? solved { get; set; }
    }
}
