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
    
    public partial class SAF_CRONOENTIDAD
    {
        public SAF_CRONOENTIDAD()
        {
            this.SAF_BASE = new HashSet<SAF_BASE>();
        }
    
        public int CODCROENT { get; set; }
        public Nullable<System.DateTime> FECINICROENT { get; set; }
        public Nullable<System.DateTime> FECFINCROENT { get; set; }
        public Nullable<int> TIPCONTCROENT { get; set; }
        public Nullable<int> TIPENTCROENT { get; set; }
        public string DESCROENT { get; set; }
        public Nullable<int> CODENT { get; set; }
        public Nullable<int> CODCRO { get; set; }
        public Nullable<System.DateTime> FECREG { get; set; }
        public Nullable<System.DateTime> FECMOD { get; set; }
        public string USUREG { get; set; }
        public string USUMOD { get; set; }
        public string ESTREG { get; set; }
    
        public virtual ICollection<SAF_BASE> SAF_BASE { get; set; }
        public virtual SAF_ENTIDADES SAF_ENTIDADES { get; set; }
        public virtual SAF_CRONOGRAMA SAF_CRONOGRAMA { get; set; }
    }
}
