namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.tblModificators")]
    public partial class tblModificator
    {
        [Key]
        public Guid UID { get; set; }

        public Guid UID_Floor { get; set; }

        public Guid UID_KZI { get; set; }

        public double? Volume { get; set; }

        public double? Mass { get; set; }

        public int? Height { get; set; }

        public int? Length { get; set; }

        public int? Thickness { get; set; }

        public bool? Console { get; set; }

        public bool? Loop { get; set; }

        public bool? Teeth { get; set; }

        public bool? TeethPart { get; set; }

        public bool? TeethCut { get; set; }

        public bool? EndLeft { get; set; }

        public bool? EndRight { get; set; }

        public bool? Heat { get; set; }

        public bool? Window { get; set; }

        public bool? Balkony { get; set; }

        public bool? Door { get; set; }

        public bool? TechCut { get; set; }

        public bool? StapleLeft120 { get; set; }

        public bool? StapleRight120 { get; set; }

        public bool? StapleLeft150 { get; set; }

        public bool? StapleRight150 { get; set; }

        public bool? StapleLeft245 { get; set; }

        public bool? StapleRight245 { get; set; }

        public bool? StapleLeft275 { get; set; }

        public bool? StapleRIght275 { get; set; }

        public bool? StapleTop { get; set; }

        [StringLength(200)]
        public string RDS { get; set; }

        [StringLength(200)]
        public string RDS_Light { get; set; }
    }
}
