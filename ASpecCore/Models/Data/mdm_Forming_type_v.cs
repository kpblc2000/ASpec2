namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mdm_Forming_type_v
    {
        [Key]
        public Guid guid { get; set; }

        public Guid? forming_dimension_guid { get; set; }

        public Guid? forming_lifting_guid { get; set; }
    }
}
