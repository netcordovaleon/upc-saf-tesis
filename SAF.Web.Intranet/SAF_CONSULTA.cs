//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAF.Web.Intranet
{
    using System;
    using System.Collections.Generic;
    
    public partial class SAF_CONSULTA
    {
        public int CODCON { get; set; }
        public string DESCON { get; set; }
        public Nullable<System.DateTime> FECREG { get; set; }
        public Nullable<System.DateTime> FECMOD { get; set; }
        public string USUREG { get; set; }
        public string USUMOD { get; set; }
        public string ESTREG { get; set; }
        public Nullable<int> CODPUB { get; set; }
        public Nullable<int> CODSOA { get; set; }
        public Nullable<int> ESTCON { get; set; }
    
        public virtual SAF_PUBLICACION SAF_PUBLICACION { get; set; }
        public virtual SAF_SOA SAF_SOA { get; set; }
    }
}
