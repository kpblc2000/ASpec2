namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("listalb")]
    public partial class listalb
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string listnum { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_album_list { get; set; }

        public virtual album album { get; set; }
    }
}
