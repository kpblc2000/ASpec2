namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logging.tbl_UserLoginForLogging")]
    public partial class tbl_UserLoginForLogging
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string UserLogin { get; set; }

        public bool actual { get; set; }
    }
}
