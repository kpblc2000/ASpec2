namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_idObType4MarkPref
    {
        [Key]
        [Column(Order = 0)]
        public Guid guid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string objecttypename { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_objecttype { get; set; }

        [StringLength(15)]
        public string Item_group { get; set; }

        [StringLength(4)]
        public string tbl_unit { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_group_id { get; set; }
    }
}
