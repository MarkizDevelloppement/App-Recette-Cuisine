using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RecetteBuisness
{
    public class Business
    {
        

        public static ObservableCollection<Recette> roulotte { get; set; }

        static Business()
        {
            roulotte = new ObservableCollection<Recette>();
        }
    }
}
