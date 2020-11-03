using RecetteBuisness;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace App_Recette_Cuisine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Recette> menu = new ObservableCollection<Recette>();
        private Recette r;
        public MainWindow()
        {
            InitializeComponent();
            Mygrid.ItemsSource = Business.roulotte;
           
        }

        private void ButtonFiltre_Click(object sender, RoutedEventArgs e)
        { 

            if (categorieFiltre.Text != "")
            {
                foreach (var item in Business.roulotte)
                {
                    if (item.categorie != "")
                    {
                        try
                        {
                            String categorie = (item.categorie);
                            if (categorie == categorieFiltre.Text)
                            {
                                menu.Add(item);
                            }
                        }
                        catch (Exception) { }
                    }
                }
                Mygrid.ItemsSource = menu;
            }
            else
            {
                Mygrid.ItemsSource = Business.roulotte;
            }
            
        }

        private void ButtonADD_Click(object sender, RoutedEventArgs e)
        {
            WindowAdd wa = new WindowAdd(this);
            wa.Show();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            menu.Clear();
            Business.roulotte.Clear();
        }

        private void print_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void chargerdb_Click(object sender, RoutedEventArgs e)
        {
            Business.roulotte.Clear();
            menu.Clear();
            RecetteAcess.GetAllRecette();
            Mygrid.ItemsSource = Business.roulotte;
        }

        private void savedb_Click(object sender, RoutedEventArgs e)
        {
            int tailleList = Business.roulotte.Count;
            for(int i = 0; i < tailleList; i++)
            {
                Recette rct = Business.roulotte[i];
                RecetteAcess.InsertRecette(rct);
            }
        }

        private void updatedb_Click(object sender, RoutedEventArgs e)
        {
            int tailleList = Business.roulotte.Count;
            for (int i = 0; i < tailleList; i++)
            {
                Recette rct = Business.roulotte[i];
                RecetteAcess.UpdateRecette(rct);
            }
        }

        
    }
}
