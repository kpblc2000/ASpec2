namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class fstn_element
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_felem { get; set; }

        public int id_name_felem { get; set; }

        [Required]
        [StringLength(50)]
        public string mark_felem { get; set; }

        [StringLength(50)]
        public string addition { get; set; }

        public virtual fstn_name fstn_name { get; set; }

        public virtual raw raw { get; set; }
    }
}
