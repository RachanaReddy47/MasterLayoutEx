using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasterLayoutEx.Models
{
    public class LoginValidationDB
    {
        static DemoEntities D = new DemoEntities();

        public static bool Validation(Login L)
        {
            var v = from l in D.Logins
                    where l.Username == L.Username && l.Password == L.Password
                    select l;
            if (v.Count() == 1)
                return true;
            else
                return false;

        }

        
        

       
       
    }
}