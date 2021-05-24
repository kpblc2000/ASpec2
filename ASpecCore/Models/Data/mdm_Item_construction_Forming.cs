namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mdm_Item_construction_Forming
    {
        [Key]
        [Column(Order = 0)]
        public Guid guid { get; set; }

        public string Document_link { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid Item_construction_guid { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid Forming_type_guid { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime updated_at { get; set; }
    }
}
