namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class end_prod_ver_consist
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_endprod_ver { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object { get; set; }

        public decimal object_count { get; set; }

        [Required]
        [StringLength(4)]
        public string object_count_unit { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime created_at { get; set; }

        [Required]
        [StringLength(50)]
        public string creator_username { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string btn_groupname { get; set; }

        public int? objectcons_ver { get; set; }

        public virtual p_units p_units { get; set; }
    }
}
