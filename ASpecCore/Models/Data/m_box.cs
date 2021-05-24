namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class m_box
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_mbox { get; set; }

        [Required]
        [StringLength(50)]
        public string box_name { get; set; }

        [StringLength(50)]
        public string box_line { get; set; }

        public virtual raw raw { get; set; }
    }
}
