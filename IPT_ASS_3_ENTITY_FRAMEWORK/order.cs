//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPT_ASS_3_ENTITY_FRAMEWORK
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public int o_id { get; set; }
        public System.DateTime o_date { get; set; }
        public int p_id { get; set; }
        public int c_id { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual product product { get; set; }
    }
}
