namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMP_view_idSubObj4objType
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_objecttype { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string objecttypename { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_subobject { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_cons { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Expr1 { get; set; }
    }
}
