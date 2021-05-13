namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class work_file
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public work_file()
        {
            prod_work_file = new HashSet<prod_work_file>();
            work_file_mark_type = new HashSet<work_file_mark_type>();
            work_file1 = new HashSet<work_file>();
            mdm_object_plain = new HashSet<mdm_object_plain>();
            zones = new HashSet<zone>();
        }

        public int id { get; set; }

        public Guid UUID { get; set; }

        [StringLength(255)]
        public string f_path { get; set; }

        [Required]
        [StringLength(255)]
        public string f_Name { get; set; }

        [StringLength(5)]
        public string f_Extension { get; set; }

        [StringLength(16)]
        public string Mark { get; set; }

        [StringLength(50)]
        public string Object { get; set; }

        [StringLength(7)]
        public string Type { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(7)]
        public string Status { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Time { get; set; }

        [StringLength(250)]
        public string Cur_user { get; set; }

        public int? Size { get; set; }

        public int? Links { get; set; }

        [Column(TypeName = "ntext")]
        public string Comment { get; set; }

        public bool? Parsed { get; set; }

        [StringLength(50)]
        public string MailDate { get; set; }

        public int? Project_id { get; set; }

        public int? Korpus_id { get; set; }

        public int? Section_id { get; set; }

        [StringLength(250)]
        public string original_login { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? loaded_date { get; set; }

        [Column("class")]
        public int? _class { get; set; }

        public virtual classType classType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prod_work_file> prod_work_file { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<work_file_mark_type> work_file_mark_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<work_file> work_file1 { get; set; }

        public virtual work_file work_file2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mdm_object_plain> mdm_object_plain { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zone> zones { get; set; }
    }
}
