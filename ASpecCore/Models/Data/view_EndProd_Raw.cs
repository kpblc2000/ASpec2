namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_EndProd_Raw
    {
        [Column("технология формовки")]
        [StringLength(50)]
        public string технология_формовки { get; set; }

        [Column("метод съёма")]
        [StringLength(50)]
        public string метод_съёма { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int изменение { get; set; }

        [Column("материал спецификации")]
        [StringLength(251)]
        public string материал_спецификации { get; set; }

        [Column("количество материала")]
        public decimal? количество_материала { get; set; }

        [Key]
        [Column("ID сырья", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_сырья { get; set; }

        [Column("единицы измерения")]
        [StringLength(50)]
        public string единицы_измерения { get; set; }

        [Column("код единиц измерения")]
        [StringLength(4)]
        public string код_единиц_измерения { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? maxdatecreate { get; set; }

        public Guid? itm_conFrm_guid { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Статус { get; set; }

        [StringLength(50)]
        public string Альбом { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(250)]
        public string марка { get; set; }
    }
}
