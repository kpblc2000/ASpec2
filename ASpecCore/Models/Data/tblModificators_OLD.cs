namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ifc.tblModificators_OLD")]
    public partial class tblModificators_OLD
    {
        public Guid Id { get; set; }

        public int ProjectId { get; set; }

        [StringLength(50)]
        public string IfcGuid { get; set; }

        [StringLength(50)]
        public string SystemTag { get; set; }

        [StringLength(50)]
        public string Tag { get; set; }

        [StringLength(20)]
        public string UnitTag { get; set; }

        [StringLength(50)]
        public string FacadeType { get; set; }

        public int? Height { get; set; }

        public int? Length { get; set; }

        public int? Thickness { get; set; }

        public int? Version { get; set; }

        public int? Mass { get; set; }

        [StringLength(50)]
        public string MaterialId { get; set; }

        [StringLength(50)]
        public string MaterialName { get; set; }

        public string MaterialQuantity { get; set; }

        public int? ElementType { get; set; }

        public double? Volume { get; set; }

        public string СoloristicsTagList { get; set; }

        [StringLength(500)]
        public string EndTypeList { get; set; }

        [StringLength(500)]
        public string JointTypeList { get; set; }

        [StringLength(50)]
        public string AdvanceTag { get; set; }

        [StringLength(150)]
        public string ConstructionType { get; set; }

        [StringLength(250)]
        public string Hole { get; set; }

        [StringLength(50)]
        public string MarkPrefix { get; set; }

        [StringLength(50)]
        public string MarkSubPrefix { get; set; }

        public int? SeriesId { get; set; }

        [Required]
        public string ParseString { get; set; }

        public string JSON { get; set; }

        public bool? IsProduct { get; set; }

        public string SAT { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(150)]
        public string CreateUser { get; set; }

        public virtual tblProject tblProject { get; set; }

        public virtual tblSery tblSery { get; set; }
    }
}
