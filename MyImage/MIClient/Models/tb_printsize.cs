//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MIClient.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_printsize
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_printsize()
        {
            this.tb_order = new HashSet<tb_order>();
        }
    
        public int pr_id { get; set; }
        public string pr_size { get; set; }
        public decimal pr_price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_order> tb_order { get; set; }
    }
}