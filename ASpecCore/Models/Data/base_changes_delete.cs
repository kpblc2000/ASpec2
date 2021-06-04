namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class base_changes_delete
    {
        [StringLength(128)]
        public string ServerName { get; set; }

        [StringLength(128)]
        public string DB_Name { get; set; }

        [Key]
        [Column(Order = 0)]
        public string ViewName { get; set; }

        [StringLength(2)]
        public string type { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime create_date { get; set; }

        [Column("View script")]
        public string View_script { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime modify_date { get; set; }
    }
}
