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
    /// Interaction logic for ModifierConsultation.xaml
    /// </summary>
    public partial class ModifierConsultation : UserControl
    {
        public Consultations Consultations { get; set; }
        public bool IsSaved { get; private set; } = false; // Indique si les modifications ont été enregistrées

        public ModifierConsultation(Consultations consultation)
        {
            InitializeComponent();
            this.Consultations = consultation;
            DataContext = this.Consultations; // Lier le DataContext à l'infirmier
        }


        private void Enregistrer_Click(object sender, RoutedEventArgs e)
        {
            IsSaved = true; // Indique que les modifications ont été enregistrées
            MessageBox.Show("L' infermier a été modifié avec succès !"); // Affiche un message de succès

        }


        // Événement déclenché lors du clic sur le bouton "Annuler"
        private void Annuler_Click(object sender, RoutedEventArgs e)
        {

            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null && mainWindow.BackupConsultation.ContainsKey(Consultations.ID))
            {
                // Restaurer les données initiales de l'infirmier depuis un backup
                var backup = mainWindow.BackupConsultation[Consultations.ID];
                Consultations.ID = backup.ID;
                Consultations.MedecinID = backup.MedecinID;
                Consultations.Patient = backup.Patient;
                Consultations.Date = backup.Date;
                Consultations.Heure = backup.Heure;
                Consultations.Observations = backup.Observations;

                // Rafraîchir l'affichage de la liste des infirmiers
                mainWindow.DataGridInfermier.Items.Refresh();
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
