//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace My.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class dbbuilding
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dbbuilding()
        {
            this.dbemployees = new HashSet<dbemployee>();
            this.dbrooms = new HashSet<dbroom>();
        }
    
        public int iBldSysID { get; set; }
        public string sBldName { get; set; }
        public string sBldAddress { get; set; }
        public byte iBldStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbemployee> dbemployees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbroom> dbrooms { get; set; }
    }
}
