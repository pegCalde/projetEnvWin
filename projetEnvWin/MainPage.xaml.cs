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
using EnvWindowsProjectQuizz.Données;
using Windows.UI;
using EnvWindowsProjectQuizz;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace projetEnvWin
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
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

        private void btnValider_Click(object sender, RoutedEventArgs e)
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
            }

        }

        private void choixEleves_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnValider.Background = new SolidColorBrush(Colors.LimeGreen);
            btnValider.Foreground = new SolidColorBrush(Colors.White);
            btnValider.FontWeight = Windows.UI.Text.FontWeights.Bold;
        }

        private void btnMaths_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(MathsPage), currentStudent);
            }

        }

        private void btnHistoire_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (currentStudent != null)
            {
                this.Frame.Navigate(typeof(HistoirePage), currentStudent);
            }
        }

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
