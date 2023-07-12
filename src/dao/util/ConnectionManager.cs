using System.Data.SqlClient;

public class ConnectionManager
{
	protected string connectionString = "server= localhost ; database= GestionInventario; integrated security= true";
    public SqlConnection GetConnection()
    {
        SqlConnection connection = new (connectionString);
        connection.Open();
        return connection;
    }

    public void ReleaseConnection(SqlConnection connection)
    {
        connection.Close();
        connection.Dispose();
    }
}