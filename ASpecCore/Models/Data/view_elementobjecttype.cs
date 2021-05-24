namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_elementobjecttype
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string unicname { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool isproduct { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string objecttypename { get; set; }

        public bool? isendproduct { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string unicname_trim { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_objecttype { get; set; }

        public bool? actual { get; set; }

        public int? id_type4mark { get; set; }

        [StringLength(50)]
        public string typeShortName { get; set; }
    }
}
