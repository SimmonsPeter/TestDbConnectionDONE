using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoireSQL10
{
    internal class EtudiantDataContext
    {

        public string ConnectionString { get; set; }
        

        public EtudiantDataContext(string connectionString = "Data Source=localhost; Initial Catalog=BaseEtudiants;Integrated Security=true")
        {
            ConnectionString = connectionString;
        }

        //définition des méthodes utilitaires
        public List<Programme> GetAllProgrammes()
        {
            List<Programme> programmeList = new List<Programme>();
            //établir la connexion avec le serveur SQL
            SqlConnection myConn= new SqlConnection(ConnectionString);
            myConn.Open();
            string sql = "Select * from Programmes";
            //créer l'objet commande
            SqlCommand cmd = new SqlCommand(sql, myConn);//myConn.CreateCommand();
            //executer la requete
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Programme p = new Programme(reader.GetInt32(0), reader.GetString(1));
                    programmeList.Add(p);
                }
            }
            //fermer le reader et la connexion
            reader.Close();
            myConn.Close();
            return programmeList;
        }
        public void InsertProgramme(Programme p)
        {
            //établir la connexion avec le serveur SQL
            SqlConnection myConn = new SqlConnection(ConnectionString);
            myConn.Open();
            string sql = "insert into Programmes (ProgrammeID,ProgrammeName) values (@programmeID,@programmeName)";
            //créer l'objet commande
            SqlCommand cmd = new SqlCommand(sql, myConn);//myConn.CreateCommand();
            //initialiser les paramètres
            cmd.Parameters.Add(new SqlParameter("programmeID", p.ProgrammeID));
            cmd.Parameters.Add(new SqlParameter("programmeName", p.ProgrammeName));

            //executer la requete
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        public void DeleteProgramme(int id)
        {
            //établir la connexion avec le serveur SQL
            SqlConnection myConn = new SqlConnection(ConnectionString);
            myConn.Open();
            string sql = "delete from Progammes where ProgrammeId=@id";
            //créer l'objet commande
            SqlCommand cmd = new SqlCommand(sql, myConn);//myConn.CreateCommand();
            //initialiser les paramètres
            cmd.Parameters.Add(new SqlParameter("id", id));
            //executer la requete
            cmd.ExecuteNonQuery();
            myConn.Close();
        }
        public void UpdateProgramme(Programme p)
        {
            //établir la connexion avec le serveur SQL
            SqlConnection myConn = new SqlConnection(ConnectionString);
            myConn.Open();
            string sql = "update Programmes set ProgrammeName=@name where ProgrammeId=@id";
            //créer l'objet commande
            SqlCommand cmd = new SqlCommand(sql, myConn);//myConn.CreateCommand();
            //initialiser les paramètres
            cmd.Parameters.Add(new SqlParameter("id", p.ProgrammeID));
            cmd.Parameters.Add(new SqlParameter("name", p.ProgrammeName));
            //executer la requete
            cmd.ExecuteNonQuery();
            //fermer la connexion
            myConn.Close();
        }
    }
}
