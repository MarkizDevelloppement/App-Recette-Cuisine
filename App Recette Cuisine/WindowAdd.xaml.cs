using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace App_Recette_Cuisine
{
    /// <summary>
    /// Interaction logic for WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        public WindowAdd()
        {
            InitializeComponent();
        }

        public void Button_Click_AddClose(object sender, RoutedEventArgs e)
        {
            RecetteBuisness.Recette plat = new RecetteBuisness.Recette(0, titre.Text, categorie.Text, tempsprepa.Text, modeprepa.Text, nbrperson.Text,
                                                        ingrédients.Text, url.Text, origine.Text);

            if (RecetteBuisness.RecetteAcess.InsertRecette(plat))
            {
                MessageBox.Show("Les infos client ont bien été envoyés");
            }
            else
            {
                MessageBox.Show("Erreur, les infos client n'ont pas pu été envoyés");
            }
            this.Close();
        }

        public void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            RecetteBuisness.Recette plat = new RecetteBuisness.Recette(0, titre.Text, categorie.Text, tempsprepa.Text, modeprepa.Text, nbrperson.Text,
                                                        ingrédients.Text, url.Text, origine.Text);
            //Buisness.clients.Add(phone);
            if (RecetteBuisness.RecetteAcess.InsertRecette(plat))
            {
                MessageBox.Show("Les infos client ont bien été envoyés");
            }
            else
            {
                MessageBox.Show("Erreur, les infos client n'ont pas pu été envoyés");
            }
        }

        private void MenuItem_Click_Clear(object sender, RoutedEventArgs e)
        {
            titre.Clear();
            categorie.Clear();
            tempsprepa.Clear();
            modeprepa.Clear();
            nbrperson.Clear();
            ingrédients.Clear();
            //url ou bouton add images?
            origine.Clear();
        }

        private void MenuItem_Click_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
