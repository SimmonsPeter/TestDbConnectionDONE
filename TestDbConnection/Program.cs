

//construction de la chaine de connection
using System.Data.SqlClient;
using System.Linq.Expressions;

string strConnection = "Data Source=(local);"//nom du serveur
    + "Initial Catalog=Northwind;"//nom de la base de donné
    +"Integrated Security=SSPI";//authentification windows

//creation de l'objet connection
SqlConnection myConnection = new SqlConnection(strConnection);
//se connecter a la base de onnee
try
{
    myConnection.Open();
    Console.WriteLine("Connexion établie");
}catch(Exception ex)
{
    Console.WriteLine("Connexion échouée");
    Console.WriteLine(ex.Message);
}