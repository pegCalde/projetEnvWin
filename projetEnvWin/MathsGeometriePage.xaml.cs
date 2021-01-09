using Microsoft.UI.Xaml.Controls;
using projetEnvWin.Données;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace projetEnvWin
{
    /// <summary>
    /// Page faite par Peggy et Guillaume
    /// </summary>
    public sealed partial class MathsGeometriePage : Page
    {
        Eleve currentStudent;
        Matiere maths = new Matiere(new List<Partie>(), "Maths");
        public MathsGeometriePage()
        {
            this.InitializeComponent();
            generateQuestions();
        }

        public void generateQuestions()
        {
            fillMathsPartie(0, 5, "Géométrie");
            Partie geo = maths.ListePartie[0];
            Grid tmp = new Grid();


            foreach (Question q in geo.ListeQuestion)
            {
                RowDefinition questRow = new RowDefinition();
                questRow.Height = new GridLength(1.0, GridUnitType.Star);
                form.RowDefinitions.Add(questRow);
                tmp = generateQuestion(q);
                Grid.SetRow(tmp, form.RowDefinitions.Count - 1);
                form.Children.Add(tmp);
            }
        }

        public Grid generateQuestion(Question question)
        {
            StackPanel firstPanel = new StackPanel();
            Grid container = new Grid();

            RowDefinition firstRow = new RowDefinition();
            firstRow.Height = new GridLength(1.0, GridUnitType.Star);
            RowDefinition secondRow = new RowDefinition();
            secondRow.Height = new GridLength(1.0, GridUnitType.Star);

            container.RowDefinitions.Add(firstRow);
            container.RowDefinitions.Add(secondRow);

            List<RadioButton> test = new List<RadioButton>();
            TextBlock enonce = new TextBlock();
            enonce.Text = question.Enonce;
            enonce.Foreground = new SolidColorBrush(Colors.White);
            enonce.FontWeight = Windows.UI.Text.FontWeights.Bold;
            container.Children.Add(enonce);
            Grid.SetRow(enonce, 0);
            firstPanel.Orientation = Orientation.Horizontal;
            firstPanel.Background = new SolidColorBrush(Colors.DarkBlue);


            foreach (Reponse r in question.ReponsesPossibles)
            {
                if (question.Types == Question.Type.CLOSE)
                {
                    RadioButton tmp = new RadioButton();
                    tmp.Content = r.Contenu;
                    tmp.Foreground = new SolidColorBrush(Colors.White);
                    tmp.FontWeight = Windows.UI.Text.FontWeights.Bold;
                    firstPanel.Children.Add(tmp);

                }
                else if (question.Types == Question.Type.QCM)
                {
                    CheckBox tmp = new CheckBox();
                    tmp.Content = r.Contenu;
                    firstPanel.Children.Add(tmp);
                }
            }
            Grid.SetRow(firstPanel, 1);
            container.Children.Add(firstPanel);

            return container;
        }

        public void fillMathsPartie(int index, int length, string nom)
        {
            QuestionsMaths QMaths = new QuestionsMaths();
            List<Question> lQuest = new List<Question>();

            for (int i = index; i < index + length; i++)
            {
                lQuest.Add(QMaths[i]);
            }

            Partie mathsPart = new Partie(lQuest, nom);
            maths.ListePartie.Add(mathsPart);
        }

        /*fait par Peggy*/
        /* ici permet d'afficher le nom de l'élève et de bloquer l'accès aux pages des matières aux élèves non connectés*/
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

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            foreach (Grid g in form.Children)
            {
                TextBlock tmp = g.Children[0] as TextBlock;
                StackPanel tmp2 = g.Children[1] as StackPanel;
                Question Qattributed = maths.ListePartie[0][tmp.Text];
                for (int i = 0; i < tmp2.Children.Count; i++)
                {

                    if (tmp2.Children[i].GetType() == typeof(CheckBox))
                    {
                        CheckBox element = tmp2.Children[i] as CheckBox;
                        string content = (string)element.Content;
                        Reponse Rattributed = Qattributed[content];

                        if (Rattributed.Statut == 1)
                        {
                            element.Background = new SolidColorBrush(Colors.Green);
                        }
                        else
                        {
                            element.Background = new SolidColorBrush(Colors.Red);
                        }
                    }
                    else
                    {
                        RadioButton element = tmp2.Children[i] as RadioButton;
                        string content = (string)element.Content;
                        Reponse Rattributed = Qattributed[content];

                        if (Rattributed.Statut == 1)
                        {
                            element.Background = new SolidColorBrush(Colors.Green);
                        }
                        else
                        {
                            element.Background = new SolidColorBrush(Colors.Red);
                        }
                    }


                }
            }
        }
        /* /fait par Peggy*/


        /*fait par Guillaume*/




    }
}
