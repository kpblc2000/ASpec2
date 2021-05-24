namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RCP.RCP_consistancy")]
    public partial class RCP_consistancy
    {
        [Key]
        public int id_RCP_cons { get; set; }

        public int id_RCP { get; set; }

        public int id_col_art { get; set; }

        public int? consumption { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? square_cons { get; set; }

        public virtual Colour_article Colour_article { get; set; }

        public virtual RCP_nomenclature RCP_nomenclature { get; set; }
    }
}
