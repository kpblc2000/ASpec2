namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view1
    {
        [StringLength(20)]
        public string StartWorkDate { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string UserLogin { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FullTimeWork { get; set; }
    }
}
