//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASpecWpfDbFirstTest.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class listalb
    {
        public string listnum { get; set; }
        public int id_album_list { get; set; }
    
        public virtual album album { get; set; }
    }
}
