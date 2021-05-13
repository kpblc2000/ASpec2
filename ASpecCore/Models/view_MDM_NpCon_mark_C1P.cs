namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_MDM_NpCon_mark_C1P
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int modification_num { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? дата { get; set; }

        [StringLength(50)]
        public string creator_username { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string blkname { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string Hand_mark_no_colour { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_construction_id { get; set; }

        [StringLength(50)]
        public string created_original_login { get; set; }
    }
}
