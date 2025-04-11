using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionPersonnelMedicale
{
    /// <summary>
    /// Logique d'interaction pour Modifiermedicin.xaml
    /// </summary>
    public partial class Modifiermedicin : UserControl
    {
        public Medecin Medecin { get; set; } // Objet médecin à modifier
        public bool IsSaved { get; private set; } = false; // Indique si les modifications ont été enregistrées

        public Modifiermedicin(Medecin medecin)
        {
            InitializeComponent();
            Medecin = medecin;
            DataContext = Medecin; // Définit le DataContext pour la liaison des données
        }

        // Événement déclenché lors du clic sur le bouton "Enregistrer"
        private void Enregistrer_Click(object sender, RoutedEventArgs e)
        {
            IsSaved = true; // Indique que les modifications ont été enregistrées
            MessageBox.Show("Le médecin a été modifié avec succès !"); // Affiche un message de succès
            ((MainWindow)Application.Current.MainWindow).ShowMainView(); // Retourne à la vue principale
        }


        // Événement déclenché lors du clic sur le bouton "Annuler"
        private void Annuler_Click(object sender, RoutedEventArgs e)
        {

            // Récupérer la fenêtre parent (MainWindow)
            var mainWindow = Application.Current.MainWindow as MainWindow;

            if (mainWindow != null && mainWindow.BackupMedecins.ContainsKey(Medecin.ID))
            {
                // Rétablir les données initiales depuis le dictionnaire
                var backup = mainWindow.BackupMedecins[Medecin.ID];
                Medecin.Nom = backup.Nom;
                Medecin.Specialite = backup.Specialite;
                Medecin.Contact = backup.Contact;
                Medecin.Disponible = backup.Disponible;

                // Rafraîchir l'affichage
                mainWindow.DataGridMedecins.Items.Refresh();
            }

        }


        private void Retourner_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this)?.Close();
        }

        private void SetFrench_Click(object sender, RoutedEventArgs e)
        {
            // Update Buttons
            btn1.Content = "Enregistrer";
            btn2.Content = "Annuler";
            btn3.Content = "Retourner";
            btn4.Content = "Anglais";
            btn5.Content = "Français";

        }

        private void SetEnglish_Click(object sender, RoutedEventArgs e)
        {
            // Update Buttons
            btn1.Content = "Save";
            btn2.Content = "Delete";
            btn3.Content = "Return";
            btn4.Content = "English";
            btn5.Content = "French";
        }

    }
}
