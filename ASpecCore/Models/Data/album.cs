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
    
    public partial class album
    {
        public int id_album { get; set; }
        public string name_alb { get; set; }
        public string description_alb { get; set; }
        public Nullable<bool> in_design { get; set; }
        public string compr_name { get; set; }
        public string created_alb_orig_login { get; set; }
        public string file_path { get; set; }
        public Nullable<bool> is_end_prod_alb { get; set; }
        public Nullable<int> id_fact { get; set; }
    
        public virtual factory factory { get; set; }
    }
}
