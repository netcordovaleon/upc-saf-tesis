//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAF.Web
{
    using System;
    using System.Collections.Generic;
    
    public partial class SAF_FALTAJUSTIFICA
    {
        public int CODFALJUS { get; set; }
        public Nullable<int> CODPROEQU { get; set; }
        public Nullable<System.DateTime> FECFALJUS { get; set; }
        public string COMENTFALJUS { get; set; }
        public Nullable<System.DateTime> FECREG { get; set; }
        public Nullable<System.DateTime> FECMOD { get; set; }
        public string USUREG { get; set; }
        public string USUMOD { get; set; }
        public string ESTREG { get; set; }
    
        public virtual SAF_PROPEQUIPO SAF_PROPEQUIPO { get; set; }
    }
}
