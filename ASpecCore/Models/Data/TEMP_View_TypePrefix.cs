namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMP_View_TypePrefix
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_objecttype_pref { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string objecttypename { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string prefixval { get; set; }
    }
}
