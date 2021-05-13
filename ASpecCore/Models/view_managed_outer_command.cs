namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_managed_outer_command
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_lisp { get; set; }
    }
}
