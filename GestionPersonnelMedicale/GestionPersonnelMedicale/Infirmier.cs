namespace GestionPersonnelMedicale
{
    public class Infermier
    {
        public int ID { get; set; } // Identifiant unique de l'infirmier
        public string Nom { get; set; } // Nom de l'infirmier
        public int Experience { get; set; } // Nombre d'années d'expérience
        public string Equipe { get; set; } // Équipe de travail (e.g., Jour, Nuit)
        public bool Disponible { get; set; } // Disponibilité de l'infirmier
        public string Contact { get; set; } // Coordonnées de contact de l'infirmier
        public int DepartementID { get; set; } // ID du département auquel appartient l'infirmier
    }

}
