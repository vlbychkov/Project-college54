//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Проект
{
    using System;
    using System.Collections.Generic;
    
    public partial class zavuch
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string sname { get; set; }
        public string fatherName { get; set; }
        public Nullable<int> id_pol { get; set; }
    
        public virtual pol_tab pol_tab { get; set; }
    }
}
