using System;

namespace GestionPersonnelMedicale
{
     public class Consultations
    {
        public int ID { get; set; } // Identifiant unique de la consultation
        public int MedecinID { get; set; } // ID du médecin
        public string Patient { get; set; } // Nom du patient
        public DateTime Date { get; set; } // Date de la consultation
        public string Heure { get; set; } // Heure de la consultation
        public string Observations { get; set; } // Observations de la consultation
      
    }
}
