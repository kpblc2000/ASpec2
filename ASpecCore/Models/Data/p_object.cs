namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class p_object
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public p_object()
        {
            objectconsist = new HashSet<objectconsist>();
            objectconsist1 = new HashSet<objectconsist>();
        }

        public int? id_normdoc_pobj { get; set; }

        [Key]
        public int id_object { get; set; }

        public int id_objecttype_pobj { get; set; }

        [Required]
        [StringLength(4)]
        public string unitsguid_pobj { get; set; }

        public bool isagreed { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime createdate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? agreedate { get; set; }

        [StringLength(50)]
        public string created_original_login { get; set; }

        [Required]
        [StringLength(50)]
        public string created_comp_name { get; set; }

        [Required]
        [StringLength(50)]
        public string created_username { get; set; }

        [StringLength(50)]
        public string agree_original_login { get; set; }

        [StringLength(50)]
        public string agree_comp_name { get; set; }

        [StringLength(50)]
        public string agree_username { get; set; }

        [Required]
        [StringLength(200)]
        public string unicname { get; set; }

        [Required]
        [StringLength(200)]
        public string unicname_trim { get; set; }

        public bool? actual { get; set; }

        public bool DeletionMark { get; set; }

        public bool Load_1C { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] row_ver { get; set; }

        public virtual normdoc normdoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<objectconsist> objectconsist { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<objectconsist> objectconsist1 { get; set; }

        public virtual objecttype objecttype { get; set; }

        public virtual product product { get; set; }

        public virtual raw raw { get; set; }

        public virtual p_units p_units { get; set; }
    }
}
