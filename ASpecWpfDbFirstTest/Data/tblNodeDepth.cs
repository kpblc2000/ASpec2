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
    
    public partial class tblNodeDepth
    {
        public int id { get; set; }
        public int id_album { get; set; }
        public string nodeName { get; set; }
        public int Depth { get; set; }
        public int Thickness { get; set; }
        public string Description { get; set; }
    
        public virtual album album { get; set; }
    }
}
