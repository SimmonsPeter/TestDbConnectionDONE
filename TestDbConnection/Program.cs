

//construction de la chaine de connection
using System.Data;
using System.Data.SqlClient;


string strConnection = "Data Source=(local);"//nom du serveur
    + "Initial Catalog=Northwind;"//nom de la base de donné
                                  //+"Integrated Security=SSPI";//authentification windows
    + "User id=sa; Password=sql";

//creation de l'objet connection
SqlConnection myConnection = new SqlConnection(strConnection);
//se connecter a la base de onnee
try
{
    myConnection.Open();
    Console.WriteLine("Connexion établie");
    //ajouter un nouveau client à la table customers
    string requete = "insert into Customers(CustomerID,ContactName,CompanyName)" +
        "values (@code,@name,@company)";
    SqlCommand cmd = new SqlCommand(requete, myConnection);
    cmd.CommandType = CommandType.Text;//spécifier le type de la commande
    //initialiser les paramètres
    cmd.Parameters.Add(new SqlParameter("code", "AAAA2"));
    cmd.Parameters.Add(new SqlParameter("name", "XXXXX"));
    cmd.Parameters.Add(new SqlParameter("company", "YYYYY"));
    //executer la requete
    //int nbLigne = cmd.ExecuteNonQuery();
    //Console.WriteLine(nbLigne + " ligne(s) affectée(s)");
    //executer un select
    string selectRequete = "select CustomerID,ContactName,CompanyName from Customers where CustomerId='zzzzz'";//ajouter un where avec une condition impossible pour tester le if plus bas
    SqlCommand selectCommand = new SqlCommand(selectRequete, myConnection);
    selectCommand.CommandType = CommandType.Text;
    selectCommand.CommandText = selectRequete;
    //executer la requete
    SqlDataReader sqlReader = selectCommand.ExecuteReader();
    if (sqlReader.HasRows)
    {
        while (sqlReader.Read())
        {
            Console.WriteLine($"{sqlReader.GetString(0)}\t{sqlReader.GetString(1)}\t{sqlReader.GetString(2)}");
        }
    }
    else
    {
        Console.WriteLine("Aucun résultats");
    }

    //fermer le dataReader
    sqlReader.Close();
    //fermer la connexion
    myConnection.Close();
}
catch (Exception ex)
{
    Console.WriteLine("Connexion échouée");
    Console.WriteLine(ex.Message);
}