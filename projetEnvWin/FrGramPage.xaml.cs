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
using Windows.UI.Xaml.Controls.Primitives;
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
    public sealed partial class FrGramPage : Page
    {
        Matiere francais = new Matiere(new List<Partie>(), "Français");
        Eleve currentStudent;

        public FrGramPage()
        {
            this.InitializeComponent();
            generateQuestions();
        }

        public async void generateQuestions()
        {
            await loadCustomFile();
            Partie gram = francais.ListePartie[1];
            Grid tmp = new Grid();


            foreach (Question q in gram.ListeQuestion)
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
            container.Children.Add(enonce);
            Grid.SetRow(enonce, 0);
            firstPanel.Orientation = Orientation.Horizontal;


            foreach (Reponse r in question.ReponsesPossibles)
            {
                if (question.Types == Question.Type.CLOSE)
                {
                    RadioButton tmp = new RadioButton();
                    tmp.Content = r.Contenu;
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

        public async Task createAppCustomDirectory()
        {
            string pathData = "Données";
            string pathFr = "Francais";
            string pathHist = "Histoire";
            string pathMaths = "Maths";


            string pathFConj = "Conjugaison.txt";
            string pathFGram = "Grammaire.txt";
            string pathFLex = "Lexique.txt";
            string pathFOrtho = "Orthographe.txt";
            string pathHP = "Prehistoire.txt";
            string pathHMA = "MoyenAge.txt";
            string pathHEC = "EpoqueContemporaine.txt";
            string pathHTM = "TempsModerne.txt";
            string pathMC = "Calcul.txt";
            string pathMM = "Mesures.txt";
            string pathMG = "Geometrie.txt";
            string pathMN = "Numeration.txt";
            List<string> appDirectories = new List<string>(new string[] { pathFr, pathHist, pathMaths });
            List<string> subFr = new List<string>(new string[] { pathFConj, pathFGram, pathFLex, pathFOrtho });
            List<string> subHist = new List<string>(new string[] { pathHP, pathHMA, pathHEC, pathHTM });
            List<string> subMaths = new List<string>(new string[] { pathMC, pathMM, pathMG, pathMN });
            StorageFolder documents = KnownFolders.DocumentsLibrary;
            StorageFolder dataF;

            if (await documents.TryGetItemAsync(pathData) == null)
            {
                dataF = await documents.CreateFolderAsync("Données");
            }
            else
            {
                dataF = await documents.GetFolderAsync("Données");
            }

            foreach (string d in appDirectories)
            {
                StorageFolder tmp;
                if (await dataF.TryGetItemAsync(d) == null)
                {
                    tmp = await dataF.CreateFolderAsync(d); //Faire le switch quand ce dossier existe deja
                }
                else
                {
                    tmp = await dataF.GetFolderAsync(d);
                }

                StorageFolder sub;
                string fmod;

                switch (d)
                {
                    case "Francais":
                        foreach (string f in subFr)
                        {
                            fmod = f.Substring(0, f.Length - 4);
                            if (await tmp.TryGetItemAsync(fmod) == null)
                            {
                                sub = await tmp.CreateFolderAsync(fmod);
                            }
                            else
                            {
                                sub = await tmp.GetFolderAsync(fmod);
                            }
                        }
                        break;
                    case "Histoire":
                        foreach (string f in subHist)
                        {
                            fmod = f.Substring(0, f.Length - 4);
                            if (await tmp.TryGetItemAsync(fmod) == null)
                            {
                                sub = await tmp.CreateFolderAsync(fmod);
                            }
                            else
                            {
                                sub = await tmp.GetFolderAsync(fmod);
                            }
                        }
                        break;
                    case "Maths":
                        foreach (string f in subMaths)
                        {
                            fmod = f.Substring(0, f.Length - 4);
                            if (await tmp.TryGetItemAsync(fmod) == null)
                            {
                                sub = await tmp.CreateFolderAsync(fmod);
                            }
                            else
                            {
                                sub = await tmp.GetFolderAsync(fmod);
                            }
                        }
                        break;
                }
            }

        }

        public async Task loadCustomFile()
        {
            List<Partie> tmpFr = new List<Partie>();
            Matiere Francais = new Matiere(tmpFr, "Français");
            string pathFConj = "Conjugaison.txt";
            string pathFGram = "Grammaire.txt";
            string pathFLex = "Lexique.txt";
            string pathFOrtho = "Orthographe.txt";

            List<string> appFiles = new List<string>(new string[] { pathFConj, pathFGram, pathFLex, pathFOrtho });

            await createAppCustomDirectory();

            StorageFolder dataF = await KnownFolders.DocumentsLibrary.GetFolderAsync("Données");
            StorageFolder dataFrFolder = await dataF.GetFolderAsync("Francais");
            StorageFolder appDataFolder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Données");
            StorageFolder appDataFrFolder = await appDataFolder.GetFolderAsync("Francais");

            foreach (String f in appFiles)
            {
                Debug.WriteLine(f.Substring(0, f.Length - 4));
                StorageFolder appDataFrSub = await appDataFrFolder.GetFolderAsync(f.Substring(0, f.Length - 4));
                StorageFolder dataFSub = await dataFrFolder.GetFolderAsync(f.Substring(0, f.Length - 4));
                StorageFile currentQFile;
                StorageFile currentAFile;

                if (await dataFSub.TryGetItemAsync("Q_" + f) == null && await dataFSub.TryGetItemAsync("A_" + f) == null)
                {
                    Debug.WriteLine("Local App File for " + f.Substring(0, f.Length - 4));
                    currentQFile = await appDataFrSub.GetFileAsync("Q_" + f);
                    currentAFile = await appDataFrSub.GetFileAsync("A_" + f);


                }
                else
                {
                    Debug.WriteLine("User File for " + f.Substring(0, f.Length - 4));
                    currentQFile = await dataFrFolder.GetFileAsync("Q_" + f);
                    currentAFile = await dataFrFolder.GetFileAsync("A_" + f);
                }

                string stringQ = await FileIO.ReadTextAsync(currentQFile, Windows.Storage.Streams.UnicodeEncoding.Utf8);
                string stringA = await FileIO.ReadTextAsync(currentAFile, Windows.Storage.Streams.UnicodeEncoding.Utf8);

                fillFrPartie(stringQ, stringA, f.Substring(0, f.Length - 4));
            }

        }

        public void fillFrPartie(string contentFileQ, string contentFileA, string nom)
        {

            string[] QLines = contentFileQ.Split("\r\n");
            Array.Resize(ref QLines, QLines.Length - 1);
            string[] ALines = contentFileA.Split("\r\n");
            Array.Resize(ref ALines, ALines.Length - 1);
            List<Question> lQuest = new List<Question>();


            for (int i = 0; i < QLines.Length; i += 3)
            {
                List<Reponse> tmpA = new List<Reponse>();
                List<int> lcorr = new List<int>();
                Question.Type typeQ = Question.Type.CLOSE;
                string[] lenonceA = ALines[i / 3].Split(", ");



                foreach (string corr in QLines[i + 2].Split(","))
                {

                    lcorr.Add(int.Parse(corr));
                }

                for (int j = 0; j < lenonceA.Length; j++)
                {
                    tmpA.Add(new Reponse(lenonceA[j], lcorr[j]));
                }

                switch (QLines[i + 1])
                {
                    case "CLOSE":
                        typeQ = Question.Type.CLOSE;
                        break;
                    case "QCM":
                        typeQ = Question.Type.QCM;
                        break;
                }

                Question tmpQ = new Question(QLines[i], tmpA, lcorr, typeQ);
                lQuest.Add(tmpQ);

            }

            Partie frPart = new Partie(lQuest, nom);
            francais.ListePartie.Add(frPart);
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
                Question Qattributed = francais.ListePartie[1][tmp.Text];
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
