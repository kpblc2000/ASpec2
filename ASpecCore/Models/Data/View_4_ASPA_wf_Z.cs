namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_4_ASPA_wf_Z
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UUID { get; set; }

        [StringLength(255)]
        public string f_path { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string f_Name { get; set; }

        [StringLength(5)]
        public string f_Extension { get; set; }

        [StringLength(16)]
        public string Mark { get; set; }

        [StringLength(50)]
        public string Object { get; set; }

        [StringLength(7)]
        public string Type { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(7)]
        public string Status { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime Time { get; set; }

        [StringLength(250)]
        public string Cur_user { get; set; }

        public int? Size { get; set; }

        public int? Links { get; set; }

        [Column(TypeName = "ntext")]
        public string Comment { get; set; }

        public bool? Parsed { get; set; }

        [StringLength(50)]
        public string MailDate { get; set; }

        public int? Project_id { get; set; }

        public int? Korpus_id { get; set; }
    }
}
