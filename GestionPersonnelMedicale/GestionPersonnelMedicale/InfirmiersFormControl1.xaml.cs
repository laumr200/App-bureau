using System.Windows;
using System.Windows.Controls;

namespace GestionPersonnelMedicale
{
    public partial class InfirmierFormControl : UserControl
    {
        public InfirmierFormControl()
        {
            InitializeComponent();
        }

        private void Sauvegarder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Création d'un nouvel Infirmier basé sur les valeurs saisies
                var infirmier = new Infermier
                {
                    ID = int.Parse(IDTextBox.Text),
                    Nom = NomTextBox.Text,
                    Experience = int.Parse(ExperienceTextBox.Text),
                    Equipe = EquipeTextBox.Text,
                    Disponible = DisponibleCheckBox.IsChecked ?? false,
                    Contact = ContactTextBox.Text,
                    DepartementID = int.Parse(DepartementIDTextBox.Text)
                };

                // Ajoute le nouvel infirmier à la liste d'infirmiers dans MainWindow
                ((MainWindow)Application.Current.MainWindow).Infermiers.Add(infirmier);

                // Mise à jour du StatusBar dans MainWindow pour indiquer l'ajout réussi
                ((MainWindow)Application.Current.MainWindow).StatusMessage = "Infirmier ajouté avec succès.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez saisir des valeurs valides pour ID, Expérience et Département ID.");
            }
        }
        private void Retourner_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.ShowMainView();
        }

        private void DepartementIDTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

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
