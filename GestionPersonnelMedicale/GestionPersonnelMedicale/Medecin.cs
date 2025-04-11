namespace GestionPersonnelMedicale
{
    public class Medecin
    {
        public int ID { get; set; } // Identifiant unique du médecin
        public string Nom { get; set; } // Nom du médecin
        public string Specialite { get; set; } // Spécialité du médecin 
        public bool Disponible { get; set; } // Disponibilité du médecin
        public string Contact { get; set; } // Coordonnées de contact du médecin
        public int DepartementID { get; set; } // ID du département auquel appartient le médecin
       // public Medecin SelectedMedecin { get; set; }

    }

}
