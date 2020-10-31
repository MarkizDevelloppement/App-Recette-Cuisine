using System;
using System.Collections.Generic;
using System.Text;

namespace RecetteBuisness
{
    public class Recette
    {
        public int id { get; set; }
        public String titre { get; set; }
        public String categorie { get; set; }
        public String tempsprepa { get; set; }
        public String modeprepa { get; set; }
        public String nbrperson { get; set; }
        public String ingredient { get; set; }
        public String url { get; set; }
        public String origine { get; set; }


        public Recette(int id, String titre, String categorie, String tempsprepa, String modeprepa, 
                       String nbrperson, String ingredient, String url, String origine)
        {
            
            this.titre = titre;
            this.categorie = categorie;
            this.tempsprepa = tempsprepa;
            this.modeprepa = modeprepa;
            this.nbrperson = nbrperson;
            this.ingredient = ingredient;
            this.url = url;
            this.origine = origine;
        }
    }
}
