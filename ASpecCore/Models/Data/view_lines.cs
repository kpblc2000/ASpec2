namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_lines
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_line { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_formEquip { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string formEquip_Name { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid forming_lifting_guid { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string forming_lifting { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_arm_type { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(255)]
        public string arm_typeName { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_class_of_steel { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(255)]
        public string steel_class { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_type_of_concr { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(255)]
        public string cncr_type { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool CAD { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool actual { get; set; }

        [StringLength(36)]
        public string UID_1c { get; set; }

        [StringLength(200)]
        public string short_name { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(200)]
        public string line_name { get; set; }

        public long? row_ver { get; set; }
    }
}
