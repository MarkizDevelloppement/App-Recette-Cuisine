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
                command.Connection.Close();
            }
        }
        public static bool InsertRecette(Recette r)
        {
            string sql = "INSERT INTO recette(id, titre, categorie, tempsprepa, modprepa, nbrperson, ingredient, url, origine) " +
                         "VALUEs (@id, @titre, @categorie, @tempsprepa, @modeprepa, @nbrprepa, @ingredient, @utrl, @origine)";
            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
            {
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@id", null);
                cmd.Parameters.AddWithValue("@titre", r.titre);
                cmd.Parameters.AddWithValue("@categorie", r.categorie);
                cmd.Parameters.AddWithValue("@tempsprepa", r.tempsprepa);
                cmd.Parameters.AddWithValue("@modeprepa", r.modeprepa);
                cmd.Parameters.AddWithValue("@nbrperson", r.nbrperson);
                cmd.Parameters.AddWithValue("@ingredient", r.ingrediant);
                cmd.Parameters.AddWithValue("@url", r.url);
                cmd.Parameters.AddWithValue("@origine", r.origine);

                bool result = cmd.ExecuteNonQuery() == 1;
                cmd.Connection.Close();
                return result;
            }
        }

        public static void UpdateRecette(Recette r)
        {
            string sql = "Update recette Set titre=@titre, categorie=@categorie, tempprepa=@tempprepa, modeprepa=@modeprepa, " +
                         "nbrperson=@nbrperson, ingredient=@ingredient, url=@url, origine=@origine";
            
        }

    }

    
}
