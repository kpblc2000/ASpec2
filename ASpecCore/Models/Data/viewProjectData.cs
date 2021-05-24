namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.viewProjectData")]
    public partial class viewProjectData
    {
        [Key]
        [Column(Order = 0)]
        public Guid UID_projects { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string code { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid UID_sections { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(250)]
        public string Name_sections { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid UID_floors { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(250)]
        public string Name_floors { get; set; }

        [Key]
        [Column(Order = 6)]
        public Guid UUID_Work_File { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(255)]
        public string f_Name { get; set; }

        [StringLength(255)]
        public string f_path { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 8)]
        public Guid UID_KZI_Name { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(250)]
        public string Name_KZI { get; set; }

        [Key]
        [Column(Order = 10)]
        public string matrix_Insertion { get; set; }

        [StringLength(250)]
        public string Nomenclature_type { get; set; }

        [Column("2d_Plan_KZI")]
        public string C2d_Plan_KZI { get; set; }

        [Column("2d_Fasade_KZI")]
        public string C2d_Fasade_KZI { get; set; }

        public Guid? UID_Assembly { get; set; }

        [StringLength(2000)]
        public string Assembly_Compare_LISP { get; set; }

        public string Assembly_Parameters_LISP { get; set; }

        [StringLength(250)]
        public string Name_Color { get; set; }

        public string JSON_Project_Specific { get; set; }

        public int? Version_KZI { get; set; }
    }
}
