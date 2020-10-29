using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RecetteBuisness
{
    class Business
    {
        public static ObservableCollection<Recette> Recette { get; }

        public static ObservableCollection<RecetteBuisness.Recette> roulotte { get; set; }

        static Business()
        {
            RecetteBuisness.Recette umukai = new RecetteBuisness.Recette("Umu kai", "buffet", "6hr", "four local", "20 pers", "cochon, chèvre, banane, tao " ) ;

            roulotte = new ObservableCollection<RecetteBuisness.Recette>();
        }
    }
}
