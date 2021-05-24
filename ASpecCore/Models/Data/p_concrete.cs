namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class p_concrete
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_object_concr { get; set; }

        public int id_class { get; set; }

        public int id_binder { get; set; }

        public int id_frost { get; set; }

        public int id_waterres { get; set; }

        public int id_composition { get; set; }

        public virtual p_concr_binder p_concr_binder { get; set; }

        public virtual p_concr_class p_concr_class { get; set; }

        public virtual p_concr_comp p_concr_comp { get; set; }

        public virtual p_concr_frost p_concr_frost { get; set; }

        public virtual p_concr_waterres p_concr_waterres { get; set; }

        public virtual raw raw { get; set; }
    }
}
