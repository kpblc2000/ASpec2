namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class btn_groupname_dic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_btn { get; set; }

        [Key]
        [StringLength(50)]
        public string btn_groupname { get; set; }

        [StringLength(1000)]
        public string def { get; set; }

        [StringLength(1000)]
        public string commentary { get; set; }
    }
}
