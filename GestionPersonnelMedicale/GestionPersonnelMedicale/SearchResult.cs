using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonnelMedicale
{
     public class SearchResult
    {
        public Departement Departement { get; set; }
        public List<Medecin> Medecins { get; set; }
        public List<Infermier> Infirmiers { get; set; }
    }
}
