namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Objects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Objects()
        {
            Objects1 = new HashSet<Objects>();
            projects = new HashSet<projects>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Object_id { get; set; }

        public int? Object_id_access { get; set; }

        public int? Object_id_parent { get; set; }

        public int? Object_type_id { get; set; }

        [StringLength(255)]
        public string Cadaster_number { get; set; }

        [StringLength(255)]
        public string Object_name { get; set; }

        public int? Object_number { get; set; }

        [StringLength(10)]
        public string Object_number_add { get; set; }

        public int? Project_type_id { get; set; }

        public int? Usage_mos_id { get; set; }

        public int? Address_id { get; set; }

        public int? Product_id { get; set; }

        public int? Building_part_id { get; set; }

        public int? Construction_type_id { get; set; }

        public short? Floors { get; set; }

        public int? Froor_type_id { get; set; }

        public int? Area_id { get; set; }

        public bool Is_building { get; set; }

        public bool Is_floor { get; set; }

        public bool Is_technical { get; set; }

        public Guid? Object_IDP_TUS_SID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime updated_at { get; set; }

        public Guid guid { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] version { get; set; }

        [StringLength(36)]
        public string Object_IDP_MDS_Guid1C { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Objects> Objects1 { get; set; }

        public virtual Objects Objects2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<projects> projects { get; set; }
    }
}
