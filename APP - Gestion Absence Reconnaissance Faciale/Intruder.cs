//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FaceReco
{
    using System;
    using System.Collections.Generic;
    
    public partial class Intruder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Intruder()
        {
            this.presenceHistories = new HashSet<presenceHistory>();
        }
    
        public string idIntr { get; set; }
        public string stringEncod { get; set; }
        public bool isUnknown { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<presenceHistory> presenceHistories { get; set; }
    }
}
