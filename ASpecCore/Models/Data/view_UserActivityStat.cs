namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logging.view_UserActivityStat")]
    public partial class view_UserActivityStat
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string UserLogin { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data { get; set; }

        [StringLength(16)]
        public string StartACAD { get; set; }

        [StringLength(16)]
        public string EndACAD { get; set; }

        [Column("день недели")]
        [StringLength(30)]
        public string день_недели { get; set; }

        [Column("FullTimeWork %%")]
        [StringLength(4000)]
        public string FullTimeWork___ { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FullTimeWork { get; set; }
    }
}
