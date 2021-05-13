namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_fact_lines
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_fact { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string f_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string f_prefix { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_line { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_formEquip { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(255)]
        public string formEquip_Name { get; set; }

        [Key]
        [Column(Order = 6)]
        public Guid forming_lifting_guid { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string forming_lifting { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_arm_type { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(255)]
        public string arm_typeName { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_class_of_steel { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(255)]
        public string steel_class { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_type_of_concr { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(255)]
        public string cncr_type { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool CAD { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool actual { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_fact_line { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool fact_lines_actual { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(200)]
        public string line_name { get; set; }
    }
}
