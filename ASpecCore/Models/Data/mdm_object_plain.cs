namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mdm_object_plain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mdm_object_plain()
        {
            work_file = new HashSet<work_file>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ИД { get; set; }

        [Required]
        [StringLength(4000)]
        public string Объект { get; set; }

        [Column("Тип объекта")]
        [StringLength(20)]
        public string Тип_объекта { get; set; }

        [Column("Это здание")]
        public bool Это_здание { get; set; }

        [Column("Объект ИДП")]
        public Guid? Объект_ИДП { get; set; }

        [StringLength(255)]
        public string Проект { get; set; }

        public int? Микрорайон { get; set; }

        public int? Очередь { get; set; }

        public int? Блок { get; set; }

        public int? Корпус { get; set; }

        public int? Строение { get; set; }

        [Column("Элемент объекта")]
        public int? Элемент_объекта { get; set; }

        public int? Секция { get; set; }

        public int? Этаж { get; set; }

        public int? Помещение { get; set; }

        [StringLength(4000)]
        public string no_sect_floor_address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<work_file> work_file { get; set; }
    }
}
