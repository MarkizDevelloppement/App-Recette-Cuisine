using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


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
