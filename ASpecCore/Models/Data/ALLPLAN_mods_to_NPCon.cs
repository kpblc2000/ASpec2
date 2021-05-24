namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("report.ALLPLAN_mods_to_NPCon")]
    public partial class ALLPLAN_mods_to_NPCon
    {
        [Key]
        public int id_AP_mods { get; set; }

        [StringLength(255)]
        public string Марка { get; set; }

        [StringLength(255)]
        public string модификатор { get; set; }

        public bool? modif_exist { get; set; }

        public int? id_ap { get; set; }

        [StringLength(255)]
        public string RMark { get; set; }

        public int? id_modif { get; set; }

        public int? id_mdm { get; set; }

        public int? Item_modification_id { get; set; }

        public Guid? UUID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created_date { get; set; }

        [StringLength(255)]
        public string Responsible_person { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? moved_to_Prod_mod { get; set; }

        public string comment { get; set; }

        public int? t_a { get; set; }

        public int? id_object { get; set; }
    }
}
