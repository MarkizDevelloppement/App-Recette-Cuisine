using System;
using System.Collections.Generic;
using System.Text;

namespace RecetteBuisness
{
    public class Recette
    {
        public String titre { get; set; }
        public String categorie { get; set; }
        public String tempsprepa { get; set; }
        public String modeprepa { get; set; }
        public int nbrperson { get; set; }
        public String ingrediant { get; set; }
        public String url { get; set; }
        public String origine { get; set; }

        public Recette(String titre, String categorie, String tempsprepa, String modeprepa, 
                       int nbrperson, String ingrediant, String url, String origine)
        {
            this.titre = titre;
            this.categorie = categorie;
            this.tempsprepa = tempsprepa;
            this.modeprepa = modeprepa;
            this.nbrperson = nbrperson;
            this.ingrediant = ingrediant;
            this.url = url;
            this.origine = origine;
        }
    }
}
