using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Fecha de creaciòn: 10/08/2016
 *Autor: Yony C. Calito
 *MODULO CATEDRATICOS
 */
namespace AsignaciondeCursos
{
    public class alumno
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellidp { get; set; }
        public string genero { get; set; }
        public string fec_nac { get; set; }
        public string nit { get; set; }
        public string tel { get; set; }
        public string telot { get; set; }
        public string dir { get; set; }
        public string dirot { get; set; }
        public string email { get; set; }
        public string emailot { get; set; }


        public alumno() { }

        public alumno(string ccodigo, string cnom, string cpapellido, string csapellido, string cgen, string cfec, string cnit,
                        string ctel, string ctelot, string cdir, string cdirot, string cemail, string cmailoto)
        {
            this.codigo = ccodigo;
            this.nombre = cnom;
            this.primer_apellido = cpapellido;
            this.segundo_apellidp = csapellido;
            this.genero = cgen;
            this.fec_nac = cfec;
            this.nit = cnit;
            this.tel = ctel;
            this.telot = ctelot;
            this.dir = cdir;
            this.dirot = cdirot;
            this.email = cemail;
            this.emailot = cmailoto;
        }

    }
}


