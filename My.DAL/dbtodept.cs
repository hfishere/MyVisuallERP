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
    
    public partial class dbtodept
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dbtodept()
        {
            this.dbemployees = new HashSet<dbemployee>();
        }
    
        public byte iDept { get; set; }
        public string sDept { get; set; }
        public string sNotes { get; set; }
        public string sFile { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbemployee> dbemployees { get; set; }
    }
}
