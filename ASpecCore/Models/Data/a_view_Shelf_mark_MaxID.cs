namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class a_view_Shelf_mark_MaxID
    {
        public int? id_max { get; set; }

        [StringLength(50)]
        public string right_mark { get; set; }

        [StringLength(50)]
        public string blk_handle { get; set; }

        [StringLength(50)]
        public string UUID_file { get; set; }

        [StringLength(50)]
        public string mark_from_dwg { get; set; }

        [StringLength(50)]
        public string PanType { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int shelf { get; set; }
    }
}
