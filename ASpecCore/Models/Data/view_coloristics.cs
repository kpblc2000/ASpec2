namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("color.view_coloristics")]
    public partial class view_coloristics
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string Name_sections { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string Name_floors { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(250)]
        public string Name_KZI { get; set; }

        [StringLength(250)]
        public string Name_Color { get; set; }

        [Key]
        [Column(Order = 4)]
        public string matrix_Insertion { get; set; }

        [Column("2d_Fasade_KZI")]
        public string C2d_Fasade_KZI { get; set; }

        public string JSON_Project_Specific { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "datetime2")]
        public DateTime Data_Time { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Login { get; set; }
    }
}
