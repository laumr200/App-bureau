using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows;

namespace GestionPersonnelMedicale
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class Departementrecherche : UserControl
    {

        public ObservableCollection<SearchResult> SearchResults
        {
            get => (ObservableCollection<SearchResult>)GetValue(SearchResultsProperty);
            set => SetValue(SearchResultsProperty, value);
        }

        public static readonly DependencyProperty SearchResultsProperty =
            DependencyProperty.Register("SearchResults", typeof(ObservableCollection<SearchResult>), typeof(Departementrecherche), new PropertyMetadata(null));

        public List<Departement> Departements { get; set; }

        public Departementrecherche()
        {
            InitializeComponent();

            // Exemple de données initiales (à remplacer par une source réelle)
            Departements = new List<Departement>
            {
                new Departement
                {
                    Nom = "Cardiologie",
                    Medecins = new List<Medecin> { new Medecin { Nom = "Dr. Dupont" }, new Medecin { Nom = "Dr. Martin" } },
                    Infermiers = new List<Infermier> { new Infermier { Nom = "Infermier Paul" }, new Infermier { Nom = "Infirmier Clara" } }
                },
                new Departement
                {
                    Nom = "Neurologie",
                    Medecins = new List<Medecin> { new Medecin { Nom = "Dr. Leroy" } },
                    Infermiers = new List<Infermier> { new Infermier { Nom = "Infermier Sophie" } }
                }
            };

            SearchResults = new ObservableCollection<SearchResult>();
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            // Filtrer les départements
            var searchResults = Departements
                .Where(d => d.Nom.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .Select(d => new SearchResult
                {
                    Departement = d,
                    Medecins = d.Medecins.ToList(),
                    Infirmiers = d.Infermiers.ToList()
                })
                .ToList();

            // Mettre à jour la collection des résultats
            SearchResults.Clear();
            foreach (var result in searchResults)
            {
                SearchResults.Add(result);
            }

            // Optionnel : Message si aucun résultat
            if (!SearchResults.Any())
            {
                MessageBox.Show("Aucun département trouvé pour la recherche.", "Résultats", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void ButtonRetour_Click(object sender, RoutedEventArgs e)
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
            btn7.Content = "Rechercher";

        }

        private void SetEnglish_Click(object sender, RoutedEventArgs e)
        {
            // Update Buttons
            btn7.Content = "Search";
            btn6.Content = "Return";
            btn4.Content = "English";
            btn5.Content = "French";
        }


    }
}
