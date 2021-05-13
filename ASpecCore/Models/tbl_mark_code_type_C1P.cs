namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_mark_code_type_C1P
    {
        public bool Item_group_usage { get; set; }

        [Required]
        [StringLength(50)]
        public string Item_group { get; set; }

        [Required]
        [StringLength(250)]
        public string Item_group_long { get; set; }

        public Guid guid { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_group_id { get; set; }

        public int Item_group_long_id { get; set; }
    }
}
