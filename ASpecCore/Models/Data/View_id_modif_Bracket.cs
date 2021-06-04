namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_id_modif_Bracket
    {
        [Key]
        public int id_modif { get; set; }
    }
}
