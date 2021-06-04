namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rep_prod
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? prod_type { get; set; }

        public int? prod_sort { get; set; }

        [Required]
        [StringLength(30)]
        public string prod_name { get; set; }

        [StringLength(40)]
        public string cur_user { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime date { get; set; }

        public int? Project_id { get; set; }

        public int? Korpus_id { get; set; }

        public int? series { get; set; }

        public int? factory { get; set; }

        public int? tehnology { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public bool? status { get; set; }

        public int? x1 { get; set; }

        public int? x2 { get; set; }

        public int? y1 { get; set; }

        public int? y2 { get; set; }

        public int? z1 { get; set; }

        public int? z2 { get; set; }

        public int? id_fact { get; set; }

        public int? id_line { get; set; }

        public virtual Lines Lines { get; set; }
    }
}
