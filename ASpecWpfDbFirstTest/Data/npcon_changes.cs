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
    
    public partial class npcon_changes
    {
        public string table_name { get; set; }
        public int id { get; set; }
        public byte[] version { get; set; }
        public Nullable<bool> parsed { get; set; }
        public Nullable<int> error_code { get; set; }
        public string error_message { get; set; }
        public string error_csv { get; set; }
        public int id_npcon_changes { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public string creator_name { get; set; }
        public Nullable<bool> id_existance { get; set; }
    }
}
