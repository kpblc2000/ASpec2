namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_job_files_4_Load
    {
        [Key]
        public Guid UUID { get; set; }

        [StringLength(255)]
        public string f_path { get; set; }
    }
}
