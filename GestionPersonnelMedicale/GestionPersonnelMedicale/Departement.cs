using System.Collections.ObjectModel;
using System.Windows;

namespace GestionPersonnelMedicale
{
    public class Departement
    {

        public int ID { get; set; } // Identifiant unique du département
        public string Nom { get; set; } // Nom du département
        public string Description { get; set; } // Description Chef du département  etc...
        public string Localisation { get; set; } // Localisation du département dans l'hôpital
        public List<Medecin> Medecins { get; set; } // Liste des médecins du département
        public List<Infermier> Infermiers { get; set; } // Liste des infirmiers du département
       // public ObservableCollection<Medecin> Medecin { get; set; } = new ObservableCollection<Medecin>();
        //public ObservableCollection<Infermier> Infermier { get; set; } = new ObservableCollection<Infermier>();
    }
    
}





