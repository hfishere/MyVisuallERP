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
    
    public partial class dbemployee
    {
        public long iEmpSysID { get; set; }
        public string sEmpAttdID { get; set; }
        public string sEmpCardNumber { get; set; }
        public string sEmpOtherNumber { get; set; }
        public string sEmpName { get; set; }
        public string sEmpGenIdentNum { get; set; }
        public byte iEmpGender { get; set; }
        public byte iEmpMaritalStat { get; set; }
        public byte iEmpReligion { get; set; }
        public byte iEmpLastEdu { get; set; }
        public string sEmpHTown { get; set; }
        public Nullable<System.DateTime> dEmpBirth { get; set; }
        public byte iSmokers { get; set; }
        public string sEmpAddress { get; set; }
        public string sEmpPhone { get; set; }
        public string sEmpHP { get; set; }
        public string sEmpWKPh { get; set; }
        public string sEmpWorkMail { get; set; }
        public string sEmpPersonalMail { get; set; }
        public byte iDept { get; set; }
        public byte iGrade { get; set; }
        public Nullable<byte> iJob { get; set; }
        public int iBldSysID { get; set; }
        public int iRmSysID { get; set; }
        public Nullable<System.DateTime> dEmpJn { get; set; }
        public byte iEmpStat { get; set; }
        public string sPictLink { get; set; }
    
        public virtual dbtodept dbtodept { get; set; }
    }
}
