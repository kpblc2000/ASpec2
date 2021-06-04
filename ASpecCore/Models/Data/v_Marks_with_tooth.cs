namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_Marks_with_tooth
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_prod { get; set; }
    }
}
