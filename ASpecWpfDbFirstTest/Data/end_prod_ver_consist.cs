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
    
    public partial class end_prod_ver_consist
    {
        public int id_endprod_ver { get; set; }
        public int id_object { get; set; }
        public decimal object_count { get; set; }
        public string object_count_unit { get; set; }
        public System.DateTime created_at { get; set; }
        public string creator_username { get; set; }
        public string btn_groupname { get; set; }
        public Nullable<int> objectcons_ver { get; set; }
    
        public virtual p_units p_units { get; set; }
    }
}
