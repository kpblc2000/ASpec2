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
    
    public partial class mdm_object_plain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mdm_object_plain()
        {
            this.work_file = new HashSet<work_file>();
        }
    
        public int ИД { get; set; }
        public string Объект { get; set; }
        public string Тип_объекта { get; set; }
        public bool Это_здание { get; set; }
        public Nullable<System.Guid> Объект_ИДП { get; set; }
        public string Проект { get; set; }
        public Nullable<int> Микрорайон { get; set; }
        public Nullable<int> Очередь { get; set; }
        public Nullable<int> Блок { get; set; }
        public Nullable<int> Корпус { get; set; }
        public Nullable<int> Строение { get; set; }
        public Nullable<int> Элемент_объекта { get; set; }
        public Nullable<int> Секция { get; set; }
        public Nullable<int> Этаж { get; set; }
        public Nullable<int> Помещение { get; set; }
        public string no_sect_floor_address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<work_file> work_file { get; set; }
    }
}
