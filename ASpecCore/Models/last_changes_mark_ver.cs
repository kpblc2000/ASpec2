namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class last_changes_mark_ver
    {
        [Key]
        [Column(Order = 0)]
        public int id_change { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool isVerID { get; set; }

        [StringLength(100)]
        public string creator { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime created_at { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string tbl_name { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool isUpdated { get; set; }
    }
}
