namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_permtype
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idmaintype { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idpermtype { get; set; }

        public bool? isproduct { get; set; }

        [StringLength(50)]
        public string objecttypename { get; set; }

        public bool? isendproduct { get; set; }

        public bool? isproductsubobj { get; set; }

        [StringLength(50)]
        public string objecttypenamesubobj { get; set; }

        public bool? isendproductsubobj { get; set; }

        public int? id_type4mark { get; set; }
    }
}
