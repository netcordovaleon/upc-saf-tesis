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
    
    public partial class SAF_CRONOGRAMA
    {
        public SAF_CRONOGRAMA()
        {
            this.SAF_CRONOENTIDAD = new HashSet<SAF_CRONOENTIDAD>();
        }
    
        public int CODCRO { get; set; }
        public Nullable<int> ANIOCRO { get; set; }
        public Nullable<System.DateTime> FECPUBCRO { get; set; }
        public Nullable<System.DateTime> FECMAXCREBASCRO { get; set; }
        public Nullable<int> NUMREPCRO { get; set; }
        public Nullable<System.DateTime> FECREG { get; set; }
        public Nullable<System.DateTime> FECMOD { get; set; }
        public string USUREG { get; set; }
        public string USUMOD { get; set; }
        public string ESTREG { get; set; }
        public Nullable<int> ESTCRO { get; set; }
    
        public virtual ICollection<SAF_CRONOENTIDAD> SAF_CRONOENTIDAD { get; set; }
    }
}
