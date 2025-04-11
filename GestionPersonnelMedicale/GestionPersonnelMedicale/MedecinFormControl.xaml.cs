using System.Windows;
using System.Windows.Controls;

namespace GestionPersonnelMedicale
{
    public partial class MedecinFormControl : UserControl
    {
        public MedecinFormControl()
        {
            InitializeComponent();
        }

        private void Sauvegarder_Click(object sender, RoutedEventArgs e)
        {
            // Vérifie si le champ ID est vide
            if (string.IsNullOrWhiteSpace(IDTextBox.Text))
            {
                MessageBox.Show("Le champ ID ne peut pas être vide.");
                return;
            }

            // Vérifie si le champ DépartementID est vide
            if (string.IsNullOrWhiteSpace(DepartementIDTextBox.Text))
            {
                MessageBox.Show("Le champ Département ID ne peut pas être vide.");
                return;
            }

            // Crée un nouvel objet Medecin avec les informations remplies dans le formulaire
            try
            {
                var medecin = new Medecin
                {
                    ID = int.Parse(IDTextBox.Text),
                    Nom = NomTextBox.Text,
                    Specialite = SpecialiteTextBox.Text,
                    Disponible = DisponibleCheckBox.IsChecked ?? false,
                    Contact = ContactTextBox.Text,
                    DepartementID = int.Parse(DepartementIDTextBox.Text)
                };

                // Ajoute le nouveau médecin à la liste des médecins dans MainWindow
                ((MainWindow)Application.Current.MainWindow).Medecins.Add(medecin);

                // Met à jour la barre d'état dans MainWindow pour indiquer que le médecin a été ajouté
                ((MainWindow)Application.Current.MainWindow).StatusMessage = "Médecin ajouté avec succès.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez entrer des valeurs valides pour l'ID et le Département ID.");
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
