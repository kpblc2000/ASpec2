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
    
    public partial class product_modification_20072020
    {
        public int id_prod_modif { get; set; }
        public int id_object_prod { get; set; }
        public int id_objecttype { get; set; }
        public int id_modif { get; set; }
        public Nullable<int> id_param { get; set; }
        public Nullable<int> id_mod_param_value_pool { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public string created_original_login { get; set; }
        public byte[] version { get; set; }
        public Nullable<int> Item_modification_id { get; set; }
        public Nullable<int> Item_construction_id { get; set; }
        public string modif_param_value { get; set; }
        public Nullable<bool> modif_exist { get; set; }
        public byte modif_number { get; set; }
    }
}
