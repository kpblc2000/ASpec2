using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpec2
{
    public class Album
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public string ShortName { get; set; } = null;

        [Required]
        public string Description { get; set; }

        public int CreateYear { get; set; } = DateTime.Now.Year;

        public bool IsActual { get; set; } = true;

        public int? SheetRange { get; set; }
    }
}
