namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Marks_and_modifications_nm
    {
        [StringLength(200)]
        public string Mark { get; set; }

        public string RMark { get; set; }

        [StringLength(50)]
        public string К { get; set; }

        [StringLength(50)]
        public string ПВ { get; set; }

        [StringLength(50)]
        public string З { get; set; }

        [StringLength(50)]
        public string ЗФ { get; set; }

        [StringLength(50)]
        public string ЗП { get; set; }

        [StringLength(50)]
        public string ТЛ { get; set; }

        [StringLength(50)]
        public string ТП { get; set; }

        [StringLength(50)]
        public string УТ { get; set; }

        [StringLength(50)]
        public string ПО { get; set; }

        [StringLength(50)]
        public string ПБ { get; set; }

        [StringLength(50)]
        public string ПД { get; set; }

        [StringLength(50)]
        public string ПТ { get; set; }

        [StringLength(50)]
        public string СП120 { get; set; }

        [StringLength(50)]
        public string СЛ120 { get; set; }

        [StringLength(50)]
        public string СП150 { get; set; }

        [StringLength(50)]
        public string СЛ150 { get; set; }

        [StringLength(50)]
        public string СП245 { get; set; }

        [StringLength(50)]
        public string СЛ245 { get; set; }

        [StringLength(50)]
        public string СП275 { get; set; }

        [StringLength(50)]
        public string СЛ275 { get; set; }

        [StringLength(50)]
        public string СВ { get; set; }

        [StringLength(50)]
        public string С { get; set; }

        public int? id_mdm { get; set; }

        public int? id_aperture { get; set; }

        [StringLength(255)]
        public string aperture_geometry { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? moved_to_mdm { get; set; }

        public Guid? UUID { get; set; }

        public string comment { get; set; }

        public int? t_a { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int actual { get; set; }

        [StringLength(255)]
        public string Responsible_person { get; set; }

        [StringLength(255)]
        public string type_of_insert { get; set; }

        [StringLength(50)]
        public string С200 { get; set; }

        [StringLength(50)]
        public string С240 { get; set; }

        [StringLength(50)]
        public string Г { get; set; }
    }
}
