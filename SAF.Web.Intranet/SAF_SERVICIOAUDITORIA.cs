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
    
    public partial class SAF_SERVICIOAUDITORIA
    {
        public SAF_SERVICIOAUDITORIA()
        {
            this.SAF_INVITACION = new HashSet<SAF_INVITACION>();
            this.SAF_SERAUDCARGO = new HashSet<SAF_SERAUDCARGO>();
        }
    
        public int CODSERAUD { get; set; }
        public string PERSERAUD { get; set; }
        public Nullable<System.DateTime> FECINISERAUD { get; set; }
        public Nullable<System.DateTime> FECFINSERAUD { get; set; }
        public Nullable<decimal> RETECOSERAUD { get; set; }
        public Nullable<decimal> VIASERAUD { get; set; }
        public Nullable<decimal> IGVSERAUD { get; set; }
        public Nullable<System.DateTime> FECREG { get; set; }
        public Nullable<System.DateTime> FECMOD { get; set; }
        public string USUREG { get; set; }
        public string USUMOD { get; set; }
        public string ESTREG { get; set; }
        public Nullable<int> CODBAS { get; set; }
    
        public virtual SAF_BASE SAF_BASE { get; set; }
        public virtual ICollection<SAF_INVITACION> SAF_INVITACION { get; set; }
        public virtual ICollection<SAF_SERAUDCARGO> SAF_SERAUDCARGO { get; set; }
    }
}
