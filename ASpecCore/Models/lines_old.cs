namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lines_old
    {
        [Column("_Вид_формования")]
        public string C_Вид_формования { get; set; }

        [Column("_Распалубка")]
        public string C_Распалубка { get; set; }

        [Column("_Вид_армирования")]
        public string C_Вид_армирования { get; set; }

        [Column("_Класс_стали")]
        public string C_Класс_стали { get; set; }

        [Column("_Тип_бетона")]
        public string C_Тип_бетона { get; set; }

        [Column("_CAD_данные")]
        public string C_CAD_данные { get; set; }

        [Key]
        [Column(Order = 0)]
        public int id_line { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_formEquip { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid forming_lifting_guid { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_arm_type { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_class_of_steel { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_type_of_concr { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool CAD { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool actual { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(200)]
        public string line_name { get; set; }
    }
}
