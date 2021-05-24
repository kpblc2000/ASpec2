namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("arm")]
    public partial class arm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_arm { get; set; }

        public byte diam { get; set; }

        [Required]
        [StringLength(20)]
        public string method { get; set; }

        public short? strength { get; set; }

        [StringLength(5)]
        public string armproperty { get; set; }

        public bool is_metal { get; set; }

        public virtual raw raw { get; set; }
    }
}
