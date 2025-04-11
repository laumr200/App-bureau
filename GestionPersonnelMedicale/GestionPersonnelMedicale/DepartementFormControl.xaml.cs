using System;
using System.Windows;
using System.Windows.Controls;

namespace GestionPersonnelMedicale
{
    /// <summary>
    /// Interaction logique pour DepartementFormControl.xaml
    /// </summary>
    public partial class DepartementFormControl : UserControl
    {
        public DepartementFormControl()
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

            // Vérifie si le champ Nom est vide
            if (string.IsNullOrWhiteSpace(NomTextBox.Text))
            {
                MessageBox.Show("Le champ Nom ne peut pas être vide.");
                return;
            }

            // Création d'un nouvel objet Département avec les informations remplies dans le formulaire
            try
            {
                var departement = new Departement
                {
                    ID = int.Parse(IDTextBox.Text),
                    Nom = NomTextBox.Text, // Nom du département
                    Description = DescriptionTextBox.Text, // Description
                    Localisation = LocalisationTextBox.Text // Localisation
                };

                // Ajoute le département à la collection dans MainWindow
                ((MainWindow)Application.Current.MainWindow).Departements.Add(departement);

                // Met à jour la barre d'état dans MainWindow pour indiquer que le département a été ajouté
                ((MainWindow)Application.Current.MainWindow).StatusMessage = "Département ajouté avec succès.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez entrer une valeur valide pour le champ ID.");
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
