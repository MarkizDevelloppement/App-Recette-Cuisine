using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RecetteBuisness
{
   

    public class RecetteAcess
    {
        private static MySqlConnection connection;

        static RecetteAcess()
        {
        String connString = "Server=localhost;Database=apprecette;userid=root;Pwd=";
               connection = new MySqlConnection(connString);
        }
        public static void GetAllRecette()
        {
            String sql = "SELECT * FROM recette";
            using (MySqlCommand command = new MySqlCommand(sql, connection))
            {
                command.Connection.Open();
                using (DbDataReader dbReader = command.ExecuteReader())
                {
                    while (dbReader.Read())
                    {
                        int id            = dbReader.GetInt32(0);
                        string titre      = dbReader.GetString(1);
                        string categorie  = dbReader.GetString(2);
                        string tempprepa  = dbReader.GetString(3);
                        string modprepa   = dbReader.GetString(4);
                        int nbrperson     = dbReader.GetInt32(5);
                        string ingredient = dbReader.GetString(6);
                        string url        = dbReader.GetString(7);
                        string origine    = dbReader.GetString(8);

                        // attente de la création de la class business
                        //.recette.add(id, titre, categorie, tempprepa, modprepa, nbrperson, ingredient, url, origine);

                    }

                }

            }
        }
        public static bool InsertRecette(Recette r)
        {
            return false;
        }

        public static void UpdateRecette()
        {
            
        }

    }

    
}
