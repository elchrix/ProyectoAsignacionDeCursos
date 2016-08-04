using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignaciondeCursos
{
    class ClaseParametros
    {
        public string ID { get; set; }
        public string Nombre_facultad { get; set; }
        public string No_piso { get; set; }
        public string tamanio { get; set;}
        public string Salon { get; set; }



        public ClaseParametros() { }

        public ClaseParametros(string pId, string pNombre,string pPiso,string pTamanio,string pSalon)
        {
            this.ID = pId;
            this.Nombre_facultad = pNombre;
            this.No_piso = pPiso;
            this.tamanio = pTamanio;
            this.Salon = pSalon;
        }

        
    }
  

}
