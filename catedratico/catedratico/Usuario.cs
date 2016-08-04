using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catedratico
{
    class Usuario
    {

        private static string username;


        public static string UserName
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }


    }
}
