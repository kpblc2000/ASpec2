namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class npcon_changes
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string table_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] version { get; set; }

        public bool? parsed { get; set; }

        public int? error_code { get; set; }

        [StringLength(4000)]
        public string error_message { get; set; }

        [StringLength(4000)]
        public string error_csv { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_npcon_changes { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created_at { get; set; }

        [StringLength(255)]
        public string creator_name { get; set; }

        public bool? id_existance { get; set; }
    }
}
