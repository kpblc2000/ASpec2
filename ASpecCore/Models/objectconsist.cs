namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("objectconsist")]
    public partial class objectconsist
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_cons { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_subobject { get; set; }

        public int count { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal blanklen { get; set; }

        [Required]
        [StringLength(4)]
        public string len_units { get; set; }

        public int? id_mark4subelem { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? createdate { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int objectcons_ver { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] row_ver { get; set; }

        public virtual objectmark objectmark { get; set; }

        public virtual p_units p_units { get; set; }

        public virtual p_object p_object { get; set; }

        public virtual p_object p_object1 { get; set; }
    }
}
