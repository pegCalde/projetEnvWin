using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace projetEnvWin
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class FrLexPage : Page
    {
        Eleve currentStudent;
        public FrLexPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
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

        /*ICONE MAISON POUR RETOURNER A L'ACCUEIL*/
        private void ReturnHome_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), currentStudent);
        }

        /*RETOUR A L'ACCUEIL DANS MENU*/

        private void Home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), currentStudent);
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

        /*PAGE AIDE DANS MENU*/
        
        private void btnHelp_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AidePage));
        }

        /*PAGE ABOUT DANS MENU*/

        private void btnAp_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AboutPage));
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            OnRetourRequested();
        }
        private bool OnRetourRequested()
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();

                return true;
            }

            return false;
        }
    }
}

