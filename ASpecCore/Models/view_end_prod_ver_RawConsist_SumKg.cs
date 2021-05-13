namespace ASpecCore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_end_prod_ver_RawConsist_SumKg
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_endprod_ver { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_raw { get; set; }

        public decimal? raw_countSum { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? maxdatecreate { get; set; }

        public decimal? weight { get; set; }

        public decimal? AllMass { get; set; }
    }
}
