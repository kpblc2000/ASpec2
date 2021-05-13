namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("objectprefix")]
    public partial class objectprefix
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string prefixval { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_objecttype_pref { get; set; }

        public virtual objecttype objecttype { get; set; }
    }
}
