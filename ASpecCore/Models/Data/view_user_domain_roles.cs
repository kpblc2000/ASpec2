namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_user_domain_roles
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_user { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string user_login { get; set; }

        public bool? actual { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_domain { get; set; }

        [StringLength(50)]
        public string domain { get; set; }

        public bool? actual_user_login { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string group_name { get; set; }
    }
}
