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
    /// Page commencée par Guillaume et terminée par Peggy
    /// </summary>
    public sealed partial class HistPPage : Page
    {
        Eleve currentStudent;
        List<TextBlock> textBlocks = new List<TextBlock>();
        public HistPPage()
        {
            this.InitializeComponent();
        }

        /*fait par Guillaume*/
        /* ici permet de bloquer l'accès aux pages des matières aux élèves non connectés*/
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
            this.Frame.Navigate(typeof(AboutPage), currentStudent);
        }

        /*Bouton retour disponible uniqument sur les page de quizz*/
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
        /* /fait par Peggy*/


        /*fait par Guillaume*/
        /*permet le double tap => cliquer sur une case réponse et la mettre sur la case de la frise sur laquelle on clic*/
        private void GridExo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grid currentGrid = sender as Grid;
            TextBlock currentText = currentGrid.Children[0] as TextBlock;

            currentGrid.Background = new SolidColorBrush(Colors.White);

            if(textBlocks.Count < 2)
            {
                textBlocks.Add(currentText);
            }
            if(textBlocks.Count == 2)
            {
                string tmp = textBlocks[0].Text;
                textBlocks[0].Text = textBlocks[1].Text;
                textBlocks[1].Text = tmp;
                textBlocks.Clear();
            }            
        }

        /*bouton permettant de valider les réponses et de vérifier si les réponses sont correct ou pas*/
        private async void btnValider_Click(object sender, RoutedEventArgs e)
        {
            bool reussite = true;

            if(P1.Text != "Nomade")
            {
                reussite = false;
                PP1.BorderBrush = new SolidColorBrush(Colors.Red);
            } else
            {
                PP1.BorderBrush = new SolidColorBrush(Colors.LimeGreen);
            }

            if (P2.Text != "Découverte du feu")
            {
                reussite = false;
                PP2.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {
                PP2.BorderBrush = new SolidColorBrush(Colors.LimeGreen);
            }

            if (P3.Text != "Age de pierre")
            {
                reussite = false;
                PP3.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {
                PP3.BorderBrush = new SolidColorBrush(Colors.LimeGreen);
            }

            if (P4.Text != "Agriculture")
            {
                reussite = false;
                PP4.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {
                PP4.BorderBrush = new SolidColorBrush(Colors.LimeGreen);
            }

            if(reussite)
            {
                ContentDialog Prehistoire = new ContentDialog
                {
                    Title = "Préhistoire",
                    Content = "Bravo vous avez reconstitué la frise",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await Prehistoire.ShowAsync();
            } else
            {
                ContentDialog Prehistoire = new ContentDialog
                {
                    Title = "Préhistoire",
                    Content = "La frise est incorrect, réessayez pour améliorer votre score",
                    CloseButtonText = "Ok"
                };

                ContentDialogResult result = await Prehistoire.ShowAsync();
            }
        }
    }
}
