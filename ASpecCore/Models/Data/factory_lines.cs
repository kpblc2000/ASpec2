//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASpecCore.Models.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class factory_lines
    {
        public int id_fact_line { get; set; }
        public int id_fact { get; set; }
        public int id_line { get; set; }
        public bool actual { get; set; }
    
        public virtual factory factory { get; set; }
        public virtual Line Line { get; set; }
    }
}
