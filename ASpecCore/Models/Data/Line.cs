namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Line
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Line()
        {
            factory_lines = new HashSet<factory_lines>();
        }

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
        public int id_line { get; set; }

        public int id_formEquip { get; set; }

        public Guid forming_lifting_guid { get; set; }

        public int id_arm_type { get; set; }

        public int id_class_of_steel { get; set; }

        public int id_type_of_concr { get; set; }

        public bool CAD { get; set; }

        public bool actual { get; set; }

        [Required]
        [StringLength(200)]
        public string line_name { get; set; }

        [StringLength(36)]
        public string UID_1c { get; set; }

        [StringLength(200)]
        public string short_name { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] row_ver { get; set; }

        [Required]
        public bool CanUseIfc { get; set; } = true;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factory_lines> factory_lines { get; set; }
    }
}
