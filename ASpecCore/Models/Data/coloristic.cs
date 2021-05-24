namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("color.coloristics")]
    public partial class coloristic
    {
        [Key]
        public int id_coloristics { get; set; }

        public string project_name { get; set; }

        public string section { get; set; }

        public string floor { get; set; }

        public string mark { get; set; }

        public string coloristics_index { get; set; }

        public string insert_point { get; set; }

        [StringLength(17)]
        public string rotation { get; set; }

        public string points { get; set; }

        public string json { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? creation_date { get; set; }

        [StringLength(50)]
        public string resp_person { get; set; }
    }
}
