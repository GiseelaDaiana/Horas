using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horas.Models
{
    public class User
    {
       public static bool iniciarSecion (string email , string password)

            var query = base.User.where(p => p.email == email && p.password == password)

            var query1 = from p in base.User
                         where p.email == email && p.password == password
                         select p

                         if(Queryable.count > 0)

    }
}
