namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_ALL_alias_4_login_users
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_user { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string user_login { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_domain { get; set; }

        [StringLength(50)]
        public string domain { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_lisp { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_alias { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string alias { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(8)]
        public string TypePermission { get; set; }
    }
}
