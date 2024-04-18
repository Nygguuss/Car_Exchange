using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Exchange.classes
{
    class User
    {
        public string NazwaUzytkownika { get; set; }
        public string Haslo { get; set; }
        public string Email { get; set; }

        public User(string na, string h, string e)
        {
            NazwaUzytkownika = na;
            Haslo = h;
            Email = e;
        }


    }
}
