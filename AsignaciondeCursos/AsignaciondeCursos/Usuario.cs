using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignaciondeCursos
{
    class Usuario
    {

        private static string username;
        private static string cat_id;

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
        public static string Cate_id
        {
            get
            {
                return cat_id;
            }
            set
            {
                cat_id = value;
            }
        }


    }
}
