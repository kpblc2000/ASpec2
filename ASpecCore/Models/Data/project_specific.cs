namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.project_specific")]
    public partial class project_specific
    {
        [Key]
        [Column(Order = 0)]
        public Guid UID_floors { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UID_nomenclature { get; set; }

        [Required]
        public string matrix_Insertion { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Data_Time { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        public string JSON_Project_Specific { get; set; }

        public virtual floors floors { get; set; }

        public virtual nomenclature nomenclature { get; set; }
    }
}
