namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_end_prod_ver_allMass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_endprod_ver { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? maxDate { get; set; }

        public decimal? verMass { get; set; }
    }
}
