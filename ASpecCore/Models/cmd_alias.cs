namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cmd_alias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_alias { get; set; }

        public int id_lisp { get; set; }

        [Required]
        [StringLength(50)]
        public string alias { get; set; }

        public virtual cmd_lisp cmd_lisp { get; set; }
    }
}
