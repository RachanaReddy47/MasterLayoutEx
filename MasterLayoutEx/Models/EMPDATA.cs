//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterLayoutEx.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    public partial class EMPDATA
    {
        public int EMPNO { get; set; }
        public string ENAME { get; set; }
        public string JOB { get; set; }
        public Nullable<int> MGR { get; set; }

        internal SqlException GetBaseException()
        {
            throw new NotImplementedException();
        }

        public Nullable<System.DateTime> HIREDATE { get; set; }
        public Nullable<int> SAL { get; set; }
        public Nullable<int> COMM { get; set; }
        public Nullable<int> DEPTNO { get; set; }
    }
}
