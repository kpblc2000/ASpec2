namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.KZI")]
    public partial class KZI
    {
        [Key]
        [Column(Order = 0)]
        public Guid UID_KZI_Name { get; set; }

        public Guid UID_Assembly { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Version_KZI { get; set; }

        public int? WorkFileId { get; set; }

        public bool Deleted_KZI { get; set; }

        [Column("2d_Plan_KZI")]
        public string C2d_Plan_KZI { get; set; }

        [Column("2d_Fasade_KZI")]
        public string C2d_Fasade_KZI { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Data_Time { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        public virtual work_file work_file { get; set; }

        public virtual Assembly Assembly { get; set; }

        public virtual KZI_Name KZI_Name { get; set; }
    }
}
