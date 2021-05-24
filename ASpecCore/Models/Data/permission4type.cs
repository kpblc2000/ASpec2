namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class permission4type
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idmaintype { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idpermtype { get; set; }

        public decimal? permtype_len_min { get; set; }

        public decimal? permtype_len_max { get; set; }

        public int? permtype_coun_min { get; set; }

        public int? permtype_coun_max { get; set; }

        public virtual objecttype objecttype { get; set; }

        public virtual objecttype objecttype1 { get; set; }
    }
}
