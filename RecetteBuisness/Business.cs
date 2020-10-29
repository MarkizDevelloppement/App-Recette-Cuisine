using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RecetteBuisness
{
    class Business
    {
        public static ObservableCollection<Recette> Recette { get; }

        static Business()
        {
            Recette umukai = new Recette("Umu kai", "buffet", "6hr", "four local", "20 pers", "cochon, chèvre, banane, tao " ) ;
        }
    }
}
