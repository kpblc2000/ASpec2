namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class stage_1_mods_KTD
    {
        [Key]
        public string marks { get; set; }

        [StringLength(255)]
        public string Item_modification_code { get; set; }

        [StringLength(255)]
        public string Описание_модификатора { get; set; }
    }
}
