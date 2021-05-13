namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_Item_modification_list_C1P
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_modification_id { get; set; }

        [StringLength(5)]
        public string Item_modification_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Item_modification_type { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_modification_type_id { get; set; }
    }
}
