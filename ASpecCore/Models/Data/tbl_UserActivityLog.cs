namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logging.tbl_UserActivityLog")]
    public partial class tbl_UserActivityLog
    {
        [Key]
        public Guid Guid_UserActivityLog { get; set; }

        [Required]
        [StringLength(100)]
        public string LoginName { get; set; }

        [Required]
        [StringLength(100)]
        public string UserDomain { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(100)]
        public string CommandName { get; set; }

        [Required]
        [StringLength(200)]
        public string DrawingName { get; set; }

        [Required]
        [StringLength(100)]
        public string ComputerName { get; set; }
    }
}
