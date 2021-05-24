namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_Max_ID_EndPodVer_4_ID_EndProd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_end_prod { get; set; }

        public int? id_endprod_ver { get; set; }
    }
}
