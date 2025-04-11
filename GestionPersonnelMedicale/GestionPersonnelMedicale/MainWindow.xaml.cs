using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Data;
using GestionPersonnelMedicale;
using System.DirectoryServices;
using System.Security.Cryptography.X509Certificates;

namespace GestionPersonnelMedicale
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        // ObservableCollections pour la liaison des données
        public ObservableCollection<Medecin> Medecins { get; set; }
        public Medecin SelectedMedecin { get; set; }
        public Consultations SelectedConsultation { get; set; }
        public ObservableCollection<Infermier> Infermiers { get; set; }
        public Infermier SelectedInfermier { get; set; }
        public ObservableCollection<Departement> Departements { get; set; }
        public Departement SelectedDepartement { get;   set; }
        

        public Dictionary<int, Medecin> BackupMedecins { get; set; } = new Dictionary<int, Medecin>();
        public Dictionary<int, Infermier> BackupInfermier { get; set; } = new Dictionary<int, Infermier>();
        public Dictionary<int, Departement> BackupDepartement { get; set; } = new Dictionary<int, Departement>();
         public Dictionary<int , Consultations> BackupConsultation { get; set; }= new Dictionary<int , Consultations>();

        public ObservableCollection<Consultations> Consultations { get; set; }
        private void AjouterDepartement_Click(object sender, RoutedEventArgs e)
        {
            ShowForm(new DepartementFormControl());
        }

        private void AjouterInfirmiers_Click(object sender, RoutedEventArgs e)
        {
            ShowForm(new InfirmierFormControl());
        }

        private void AjouterMedecins_Click(object sender, RoutedEventArgs e)
        {
            ShowForm(new MedecinFormControl());
        }

        private void AjouterOther_Click(object sender, RoutedEventArgs e)
        {
            ShowForm(new ConsultationFormControl());
        }

        private void ButtonRechercher_Click(object sender, RoutedEventArgs e)
        {
            ShowForm(new Departementrecherche());
        }

        private void ModifierMedecin_Click(object sender, RoutedEventArgs e)
        {
            // Vérifie si un médecin est sélectionné dans le DataGrid
            Medecin medecinSelecionado = DataGridMedecins.SelectedItem as Medecin;

            if (medecinSelecionado != null)
            {
                // Sauvegarder une copie dans le dictionnaire
                if (!BackupMedecins.ContainsKey(medecinSelecionado.ID))
                {
                    BackupMedecins[medecinSelecionado.ID] = new Medecin
                    {
                        ID = medecinSelecionado.ID,
                        Nom = medecinSelecionado.Nom,
                        Specialite = medecinSelecionado.Specialite,
                        Contact = medecinSelecionado.Contact,
                        Disponible = medecinSelecionado.Disponible
                    };
                }

                // Ouvrir le formulaire de modification
                var modifierControl = new Modifiermedicin(medecinSelecionado);
                var window = new Window { Content = modifierControl, Width = 800, Height = 450, ResizeMode = ResizeMode.NoResize };
                if (window.ShowDialog() == true)
                {
                    DataGridMedecins.Items.Refresh();
                    // Affiche un message pour indiquer que les modifications ont été enregistrées avec succès
                    MessageBox.Show("Les informations du médecin ont été mises à jour avec succès.", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                // Affiche un message d'avertissement si aucun médecin n'a été sélectionné
                MessageBox.Show("Veuillez sélectionner un médecin à modifier.", "Attention", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void ModifierInfermier_Click(object sender, RoutedEventArgs e)
        {
            // Vérifie si un médecin est sélectionné dans le DataGrid
            Infermier infermierSelecionado = DataGridInfermier.SelectedItem as Infermier;

            if (infermierSelecionado != null)
            {
                // Sauvegarder une copie dans le dictionnaire
                if (!BackupInfermier.ContainsKey(infermierSelecionado.ID))
                {
                    BackupInfermier[infermierSelecionado.ID] = new Infermier
                    {
                        ID = infermierSelecionado.ID,
                        Nom = infermierSelecionado.Nom,
                        Experience = infermierSelecionado.Experience,
                        Equipe=infermierSelecionado.Equipe,
                        DepartementID = infermierSelecionado.DepartementID,
                        Contact = infermierSelecionado.Contact,
                        Disponible = infermierSelecionado.Disponible
                    };
                }

                // Ouvrir le formulaire de modification
                var modifierControl = new ModifierInfermier(infermierSelecionado);
                var window = new Window { Content = modifierControl, Width = 800, Height = 450, ResizeMode = ResizeMode.NoResize };
                if (window.ShowDialog() == true)
                {
                    DataGridInfermier.Items.Refresh();
                    // Affiche un message pour indiquer que les modifications ont été enregistrées avec succès
                    MessageBox.Show("Les informations ds l'infermier ont été mises à jour avec succès.", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                // Affiche un message d'avertissement si aucun médecin n'a été sélectionné
                MessageBox.Show("Veuillez sélectionner un infermier à modifier.", "Attention", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void ModifierDepartement_Click(object sender, RoutedEventArgs e)
        {
            // Vérifie si un médecin est sélectionné dans le DataGrid
            Departement departementSelecionado = DataGridDepartement.SelectedItem as Departement;

            if (departementSelecionado != null)
            {
                // Sauvegarder une copie dans le dictionnaire
                if (!BackupDepartement.ContainsKey(departementSelecionado.ID))
                {
                    BackupDepartement[departementSelecionado.ID] = new Departement
                    {
                        ID = departementSelecionado.ID,
                        Nom = departementSelecionado.Nom,
                        Description = departementSelecionado.Description,
                        Localisation = departementSelecionado.Localisation,
                        Medecins=departementSelecionado.Medecins,
                        Infermiers=departementSelecionado.Infermiers,

                    };
                }
                // Ouvrir le formulaire de modification
                var modifierControl = new ModifierDepartement(departementSelecionado);
                var window = new Window { Content = modifierControl, Width = 900, Height = 500, ResizeMode = ResizeMode.NoResize };
                if (window.ShowDialog() == true)
                {
                    DataGridDepartement.Items.Refresh();
                    // Affiche un message pour indiquer que les modifications ont été enregistrées avec succès
                    MessageBox.Show("Les informations du departement ont été mises à jour avec succès.", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                // Affiche un message d'avertissement si aucun médecin n'a été sélectionné
                MessageBox.Show("Veuillez sélectionner un departement à modifier.", "Attention", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ModifierConsultation_Click(object sender, RoutedEventArgs e)
        {
            // Vérifie si un médecin est sélectionné dans le DataGrid
            Consultations consultationSelecionado = DataGridConsultation.SelectedItem as Consultations;

            if (consultationSelecionado != null)
            {
                // Sauvegarder une copie dans le dictionnaire
                if (!BackupConsultation.ContainsKey(consultationSelecionado.ID))
                {
                    BackupConsultation[consultationSelecionado.ID] = new Consultations
                    {
                        ID = consultationSelecionado.ID,
                        MedecinID= consultationSelecionado.MedecinID,
                        Patient = consultationSelecionado.Patient,
                        Date = consultationSelecionado.Date,
                        Heure = consultationSelecionado.Heure,
                        Observations = consultationSelecionado.Observations,

                    };
                }
                // Ouvrir le formulaire de modification
                var modifierControl = new ModifierConsultation(consultationSelecionado);
                var window = new Window { Content = modifierControl, Width = 900, Height = 500, ResizeMode = ResizeMode.NoResize };
                if (window.ShowDialog() == true)
                {
                    DataGridConsultation.Items.Refresh();
                    // Affiche un message pour indiquer que les modifications ont été enregistrées avec succès
                    MessageBox.Show("Les informations de la consultation ont été mises à jour avec succès.", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                // Affiche un message d'avertissement si aucun médecin n'a été sélectionné
                MessageBox.Show("Veuillez sélectionner une consultation à modifier.", "Attention", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void SetFrench_Click(object sender, RoutedEventArgs e)
        {
            // Revert all UI elements to the original French state
            Title = "Système de Gestion Hospitalière";
            StatusMessage = "Prêt";

            // Update Tab Headers
            ((TabItem)tableu.Items[0]).Header = "Médecins";
            ((TabItem)tableu.Items[1]).Header = "Infirmiers";
            ((TabItem)tableu.Items[2]).Header = "Départements";
            ((TabItem)tableu.Items[3]).Header = "Consultations";

            // Update Buttons
            ButtonAddDepartment.Content = "Ajouter Département";
            ButtonAddNurses.Content = "Ajouter Infirmiers";
            ButtonAddDoctors.Content = "Ajouter Médecins";
            ButtonAddConsultation.Content = "Ajouter Consultation";
            ButtonSetFrench.Content = "Français";
            ButtonSetEnglish.Content = "Anglais";
            btnmodifierdep.Content = "Modifier";
            btnsuprimerinfermier.Content = "Supprimer";
            btnmodifierinfermier.Content = "Modifier";
            btnrecherchedep.Content = "Recherche";
            btnseprimerdep.Content = "Supprimer";
            btnsuprimermedecin.Content = "Supprimer";
            btnmodifiermedecin.Content = "Modifier";
            btnmodifierconsulatation.Content = "Modifier";
            btnsuprimerconsultation.Content = "Supprimer";
            
            
        }

        private void SetEnglish_Click(object sender, RoutedEventArgs e)
        {
            // Dynamically update UI to English
            Title = "Hospital Management System";
            StatusMessage = "Ready";

            // Update Tab Headers
            ((TabItem)tableu.Items[0]).Header = "Doctors";
            ((TabItem)tableu.Items[1]).Header = "Nurses";
            ((TabItem)tableu.Items[2]).Header = "Departments";
            ((TabItem)tableu.Items[3]).Header = "Consultations";

            // Update Buttons
            ButtonAddDepartment.Content = "Add Department";
            ButtonAddNurses.Content = "Add Nurses";
            ButtonAddDoctors.Content = "Add Doctors";
            ButtonAddConsultation.Content = "Add Consultation";
            ButtonSetFrench.Content = "French";
            ButtonSetEnglish.Content = "English";
            btnmodifierdep.Content = "Modify";
            btnsuprimerinfermier.Content = "Delete";
            btnmodifierinfermier.Content = "Modify";
            btnrecherchedep.Content = "Search";
            btnseprimerdep.Content = "Delete";
            btnsuprimermedecin.Content = "Delete";
            btnmodifiermedecin.Content = "Modify";
            btnmodifierconsulatation.Content = "Modify";
            btnsuprimerconsultation.Content = "Delete";
        }


        private void ShowForm(UserControl form)
        {
            // Afficher le formulaire spécifié et masquer les autres éléments
            ajouter.Visibility = Visibility.Visible;
            tableu.Visibility = Visibility.Collapsed;
            ButtonAddDepartment.Visibility = Visibility.Collapsed;
            ButtonAddNurses.Visibility = Visibility.Collapsed;
            ButtonAddDoctors.Visibility = Visibility.Collapsed;
            ButtonAddConsultation.Visibility = Visibility.Collapsed;
            ButtonSetEnglish.Visibility = Visibility.Collapsed;
            ButtonSetFrench.Visibility = Visibility.Collapsed;
            btnmodifierdep.Visibility = Visibility.Collapsed;
            btnsuprimerinfermier.Visibility = Visibility.Collapsed;
            btnmodifierinfermier.Visibility = Visibility.Collapsed;
            btnrecherchedep.Visibility = Visibility.Collapsed;
            btnseprimerdep.Visibility = Visibility.Collapsed;
            btnsuprimermedecin.Visibility = Visibility.Collapsed;
            btnmodifiermedecin.Visibility=Visibility.Collapsed;
            btnsuprimerconsultation.Visibility = Visibility.Collapsed;
            btnmodifierconsulatation.Visibility = Visibility.Collapsed;

            // Effacer le contenu existant (le cas échéant) pour éviter les doublons
            ajouter.Children.Clear();

            // Ajouter le formulaire au panneau 'ajouter'
            ajouter.Children.Add(form);
        }

        public void ShowMainView()
        {
            ajouter.Visibility = Visibility.Collapsed;
            tableu.Visibility = Visibility.Visible;

            ButtonAddConsultation.Visibility = Visibility.Visible;
            ButtonAddNurses.Visibility = Visibility.Visible;
            ButtonAddDoctors.Visibility = Visibility.Visible;
            ButtonAddConsultation.Visibility = Visibility.Visible;
            ButtonSetEnglish.Visibility=Visibility.Visible;
            ButtonSetFrench.Visibility=Visibility.Visible;
            btnmodifierdep.Visibility =Visibility.Visible;
            btnsuprimerinfermier.Visibility = Visibility.Visible;
            btnmodifierinfermier.Visibility = Visibility.Visible;
            btnrecherchedep.Visibility = Visibility.Visible;
            btnseprimerdep.Visibility= Visibility.Visible;
            btnsuprimermedecin.Visibility =Visibility.Visible;
            btnmodifiermedecin.Visibility= Visibility.Visible;
            btnsuprimerconsultation.Visibility = Visibility.Visible;
            btnmodifierconsulatation.Visibility = Visibility.Visible;
            ButtonAddDepartment.Visibility = Visibility.Visible;
        }

        private string _statusMessage;
        public string StatusMessage
        {
            get { return _statusMessage; }
            set
            {
                if (_statusMessage != value)
                {
                    _statusMessage = value;
                    OnPropertyChanged(nameof(StatusMessage));
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            // Initialisation des ObservableCollections
            Medecins = new ObservableCollection<Medecin>();
            Infermiers = new ObservableCollection<Infermier>();
            Departements = new ObservableCollection<Departement>();
            Consultations = new ObservableCollection<Consultations>();
            
            // Exemple de données initiales (facultatif)
            Medecins.Add(new Medecin { ID = 1, Nom = "Dra. Laura Ramirez ", Specialite = "Cardiologie", Disponible = true, Contact = "837-365-2343"  });
            Infermiers.Add(new Infermier { ID = 1, Nom = "Infirmier Martin", Experience = 10, Equipe = "Jour", Disponible = true });
          
            Medecins.Add(new Medecin { ID = 2, Nom = "Dr. Adriano Indo Ucani ", Specialite = "Neurologie", Contact = "343-297-2444", Disponible = true });
            Infermiers.Add(new Infermier { ID = 2, Nom = "Manuel", Experience = 4, Equipe = "Nuit", Disponible = true });
            
            Medecins.Add(new Medecin { ID = 3, Nom = "Dr. Olivier  ", Specialite = "Chirurgie générale", Contact = "946-955-7000", Disponible = true });
            Infermiers.Add(new Infermier { ID = 3, Nom = "joao", Experience = 1, Equipe = "matin", Disponible = false });
            

            Medecins.Add(new Medecin { ID = 4, Nom = "Dr. Olivier  ", Specialite = "Chirurgie générale", Contact = "946-955-7000", Disponible = true });
            Infermiers.Add(new Infermier { ID = 4, Nom = "Bartomeu", Experience = 3, Equipe = "apres-midi", Disponible = true });
            

            Medecins.Add(new Medecin { ID = 5, Nom = "Dr. Martin  ", Specialite = "Chirurgie", Contact = "946-922-7000", Disponible = true });
            Infermiers.Add(new Infermier { ID = 5, Nom = "cristian", Experience = 3, Equipe = "apres-midi", Disponible = true });
            
            Departements.Add(new Departement { ID = 1, Nom = "Cardiologie", Description = "Traitement des maladies du cœur", Localisation = "Aile 1, 3e étage" });
        Departements.Add(new Departement { ID = 2, Nom = "Neurologie", Description = "Soins aux patients avec des troubles neurologiques", Localisation = "Aile 2, 4e étage" });
        Departements.Add(new Departement { ID = 3, Nom = "Pédiatrie", Description = "Soins aux enfants et adolescents", Localisation = "Aile 3, 2e étage" });
        Departements.Add(new Departement { ID = 4, Nom = "Chirurgie", Description = "Interventions chirurgicales", Localisation = "Aile 4, 1er étage" });
        Departements.Add(new Departement { ID = 5, Nom = "Oncologie", Description = "Soins aux patients atteints de cancer", Localisation = "Aile 5, 5e étage" });


            // Définir le contexte de données pour que l'interface puisse lier les propriétés
            DataContext = this;
        }


        // Implémentation de INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void AjouterMedecin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SupprimerMedecin_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedMedecin != null)
            {
                var result = MessageBox.Show($"Voulez-vous vraiment supprimer {SelectedMedecin.Nom} ?",
                                             "Confirmation",
                                             MessageBoxButton.YesNo,
                                             MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    Medecins.Remove(SelectedMedecin);
                    SelectedMedecin = null;
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un médecin à supprimer.",
                                "Avertissement",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
        }


        private void SupprimerInfirmier_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedInfermier != null)
            {
                var result = MessageBox.Show($"Voulez-vous vraiment supprimer {SelectedInfermier.Nom} ?",
                                             "Confirmation",
                                             MessageBoxButton.YesNo,
                                             MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    Infermiers.Remove(SelectedInfermier);
                    SelectedInfermier = null;
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un infirmier à supprimer.",
                                "Avertissement",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
        }

        // Gestionnaire de clic pour le bouton "Supprimer Département"
        private void SupprimerDepartement_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedDepartement != null)
            {
                var result = MessageBox.Show($"Voulez-vous vraiment supprimer {SelectedDepartement.Nom} ?",
                                             "Confirmation",
                                             MessageBoxButton.YesNo,
                                             MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    Departements.Remove(SelectedDepartement);
                    SelectedDepartement = null;
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un departements à supprimer.",
                                "Avertissement",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
        }

        private void SupprimerConsultation_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedConsultation != null)
            {
                var result = MessageBox.Show($"Voulez-vous vraiment supprimer {SelectedConsultation.Patient} ?",
                                             "Confirmation",
                                             MessageBoxButton.YesNo,
                                             MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    Consultations.Remove(SelectedConsultation);
                    SelectedConsultation = null;
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une consultation à supprimer.",
                                "Avertissement",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
        }
    }
}


