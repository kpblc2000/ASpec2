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
    
    public partial class end_product_version_temp
    {
        public int id_endprod_ver { get; set; }
        public int modification_num { get; set; }
        public string modification_descr { get; set; }
        public System.DateTime created_at { get; set; }
        public string creator_username { get; set; }
        public bool eprod_actual { get; set; }
        public int ver_status { get; set; }
        public Nullable<int> execution_ver { get; set; }
        public string eprod_file_path { get; set; }
        public int id_eprod_album { get; set; }
        public int id_end_prod { get; set; }
        public Nullable<System.Guid> itm_conFrm_guid { get; set; }
        public Nullable<decimal> end_prod_weight { get; set; }
        public Nullable<decimal> end_prod_volume { get; set; }
        public Nullable<System.Guid> formin_type_guid { get; set; }
        public Nullable<int> id_workfile { get; set; }
        public Nullable<int> id_prod_workfile { get; set; }
        public Nullable<decimal> end_prod_area { get; set; }
    }
}
