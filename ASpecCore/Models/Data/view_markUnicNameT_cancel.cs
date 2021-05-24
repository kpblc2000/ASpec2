namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_markUnicNameT_cancel
    {
        [StringLength(50)]
        public string status_name { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(200)]
        public string unicname_trim { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object { get; set; }

        public int? id_status { get; set; }
    }
}
