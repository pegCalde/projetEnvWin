using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using projetEnvWin.Données;
using Windows.UI;
using projetEnvWin;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace projetEnvWin
{
    /// <summary>
    /// page faite par Guillaume et Peggy
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Eleves students;
        Eleve currentStudent;
        public MainPage()
        {
            this.InitializeComponent();
            students = new Eleves();
            choixEleves.ItemsSource = students;
            choixEleves.DisplayMemberPath = "Nom";
        }

        /*fait par Guillaume*/
        /*permet de selectionner un élève et d'afficher le nom de l'élève*/
        private async void btnValider_Click(object sender, RoutedEventArgs e)
        {
            if (choixEleves.SelectedItem == null)
            {

            }
            else
            {
                currentStudent = choixEleves.SelectedItem as Eleve;
                gridEleve.Children.Clear();
                gridEleve.RowDefinitions.Clear();
                gridEleve.ColumnDefinitions.Clear();

                TextBlock afficheEleve = new TextBlock();
                afficheEleve.Text = "Nom de l'élève : " + currentStudent.Nom;
                afficheEleve.HorizontalAlignment = HorizontalAlignment.Center;
                afficheEleve.VerticalAlignment = VerticalAlignment.Center;
                afficheEleve.FontSize = 25;
                afficheEleve.FontWeight = Windows.UI.Text.FontWeights.Bold;
                afficheEleve.Foreground = new SolidColorBrush(Colors.Gray);
                gridEleve.Children.Add(afficheEleve);

                ContentDialog auth = new ContentDialog
                {
                    Title = "Authentification",
                    Content = "Bravo vous êtes authentifié " + currentStudent.Nom,
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await auth.ShowAsync();
            }

        }

        private void choixEleves_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnValider.Background = new SolidColorBrush(Colors.LimeGreen);
            btnValider.Foreground = new SolidColorBrush(Colors.White);
            btnValider.FontWeight = Windows.UI.Text.FontWeights.Bold;
        }

        /*SECTION MATHS DANS MENU + SUR ACCUEIL*/
        private void btnMaths_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(MathsPage), currentStudent);
            }
        }

        /*PARTIES MATHS DANS MENU*/
        private void btnMgeo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(MathsGeometriePage), currentStudent);
            }
        }
        
        private void btnMcalcul_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(MathsCalculPage), currentStudent);
            }
        }
        
        private void btnMmesures_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(MathsMesuresPage), currentStudent);
            }
        }
        
        private void btnMnum_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(MathsNumPage), currentStudent);
            }
        }
        
        /*SECTION HISTOIRE DANS MENU + SUR ACCUEIL*/
        private void btnHistoire_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(HistoirePage), currentStudent);
            }
        }

        /*PARTIES HISTOIRE DANS MENU*/
        private void btnHma_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(HistMAPage), currentStudent);
            }
        }

        private void btnHtm_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(HistTMPage), currentStudent);
            }
        }
        private void btnHec_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(HistECPage), currentStudent);
            }
        }
        private void btnHp_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(HistPPage), currentStudent);
            }
        }
        
        /*SECTION FRANCAIS DANS MENU + SUR ACCUEIL*/
        private void btnFrancais_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(FrancaisPage), currentStudent);
            }
        }
        
        /*PARTIES FRANCAIS DANS MENU*/
        private void btnFrConjug_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(FrConjugPage), currentStudent);
            }
        }
        
        private void btnFrLexique_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(FrLexPage), currentStudent);
            }
        }

        private void btnFrGram_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(FrGramPage), currentStudent);
            }
        }
        private void btnFrOrtho_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(FrOrthoPage), currentStudent);
            }
        }
        /* /fait par Guillaume*/


        /*fait par Peggy*/
        /*PAGE AIDE DANS MENU*/
        private void btnHelp_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AidePage), currentStudent);
        }

        /*PAGE ABOUT DANS MENU*/
        private void btnAp_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AboutPage));
        }
        /* /fait par Peggy*/


        /*fait par Guillaume*/
        /*ici permet de bloquer l'accès aux pages des matières aux élèves non connectés*/
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter == "")
            {

            }
            else
            {
                base.OnNavigatedTo(e);

                currentStudent = e.Parameter as Eleve;

                gridEleve.Children.Clear();
                gridEleve.RowDefinitions.Clear();
                gridEleve.ColumnDefinitions.Clear();

                TextBlock afficheEleve = new TextBlock();
                afficheEleve.Text = "Nom de l'élève : " + currentStudent.Nom;
                afficheEleve.HorizontalAlignment = HorizontalAlignment.Center;
                afficheEleve.VerticalAlignment = VerticalAlignment.Center;
                afficheEleve.FontSize = 25;
                afficheEleve.FontWeight = Windows.UI.Text.FontWeights.Bold;
                afficheEleve.Foreground = new SolidColorBrush(Colors.Gray);
                gridEleve.Children.Add(afficheEleve);
            }

        }
    }
}
