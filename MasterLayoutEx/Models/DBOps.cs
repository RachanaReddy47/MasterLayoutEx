using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MasterLayoutEx.Models
{
    public class DBOps
    {
        static DemoEntities D = new DemoEntities();
        public static List<EMPDATA> GetAll()
        {
            var E = from l in D.EMPDATAs
                    select l;
            return E.ToList();
        }

        public static string InsertEmp(EMPDATA Emp)
        {
            try
            {
                D.EMPDATAs.Add(Emp);
                D.SaveChanges();
            }
            catch (DbUpdateException E)
            {
                SqlException ex = E.GetBaseException() as SqlException;
                if (ex.Message.Contains("EMP_PK"))
                    return "Employee no already Exists";
                else if (ex.Message.Contains("FK__EMPDATA_DEPTNO"))
                    return "No such Deptno exists";
                else
                    return "Error Ocurred";
            }
            return "1 row inserted";
        }

        public static EMPDATA EditEmp(int eno)
        {
            var E = from l in D.EMPDATAs
                    where l.EMPNO==eno
                    select l;
            return E.First();
        }

        public static string Update(EMPDATA E)
        {
            var e = from l in D.EMPDATAs
                    where l.EMPNO == E.EMPNO
                    select l;
            EMPDATA emp = e.First();
            emp.ENAME = E.ENAME;
            emp.JOB = E.JOB;
            emp.MGR = E.MGR;
            emp.HIREDATE = E.HIREDATE;
            emp.SAL = E.SAL;
            emp.COMM = E.COMM;
            emp.DEPTNO = E.DEPTNO;
            D.SaveChanges();
            return "1 row Updated ";
        }

        public static string DeleteEmp(int eno)
        {
            var e = from l in D.EMPDATAs
                    where l.EMPNO == eno
                    select l;
            EMPDATA E = e.First();
            D.EMPDATAs.Remove(E);
            D.SaveChanges();
            return "1 Row Deleted";
        }

        public static List<EMPDATA> CBKGetEmp(int[] CBK)
        {
            var E = from l in D.EMPDATAs
                    where CBK.Contains(l.EMPNO) == true
                    select l;
            return E.ToList();
        }
    }

    
}