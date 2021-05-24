namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_ItemConstModif
    {
        public int? id_object_prod { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_objecttype { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_modif { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_modification_id { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_construction_modification_id { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_construction_id { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid guid { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "datetime2")]
        public DateTime updated_at { get; set; }

        [StringLength(5)]
        public string Item_modification_code { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string Item_modification_type { get; set; }
    }
}
