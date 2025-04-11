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
    /// Interaction logic for ConsultationFormControl.xaml
    /// </summary>
    public partial class ConsultationFormControl : UserControl
    {
        public ConsultationFormControl()
        {
            InitializeComponent();
        }

        private void SauvegarderClick(object sender, RoutedEventArgs e)
        {
            // Vérifie si tous les champs sont remplis
            if (string.IsNullOrWhiteSpace(IDTextBox.Text) || string.IsNullOrWhiteSpace(PatientTextBox.Text) ||
                string.IsNullOrWhiteSpace(HeureTextBox.Text) || DatePicker.SelectedDate == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            // Crée un nouvel objet Consultation avec les informations remplies dans le formulaire
            try
            {
                var consultation = new Consultations
                {
                    ID = int.Parse(IDTextBox.Text),
                    MedecinID = 1, // ID du médecin, à ajuster selon la logique
                    Patient = PatientTextBox.Text,
                    Date = DatePicker.SelectedDate.Value,
                    Heure = HeureTextBox.Text,
                    Observations = ObservationsTextBox.Text
                };

                // Ajoute la consultation à la liste des consultations dans MainWindow
                ((MainWindow)Application.Current.MainWindow).Consultations.Add(consultation);

                // Met à jour la barre d'état dans MainWindow pour indiquer que la consultation a été ajoutée
                ((MainWindow)Application.Current.MainWindow).StatusMessage = "Consultation ajoutée avec succès.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez entrer des valeurs valides pour les champs.");
            }
        }

        private void Retourner_Click(object sender, RoutedEventArgs e)
        {
            // Retourne à la vue principale
            ((MainWindow)Application.Current.MainWindow).ShowMainView();
        }


        private void SetFrench_Click(object sender, RoutedEventArgs e)
        {
            // Update Buttons

            btn6.Content = "Retourner";
            btn4.Content = "Anglais";
            btn5.Content = "Français";
            btn7.Content = "Sauvegarder";

        }

        private void SetEnglish_Click(object sender, RoutedEventArgs e)
        {
            // Update Buttons
            btn7.Content = "Save";
            btn6.Content = "Return";
            btn4.Content = "English";
            btn5.Content = "French";
        }
    }
}
