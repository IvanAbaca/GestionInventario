using System.Data.SqlClient;

public class ConnectionManager
{
	protected string connectionString = "server= localhost ; database= GestionInventario; integrated security= true";
    public SqlConnection GetConnection()
    {
        SqlConnection connection = new (connectionString);
        connection.Open();
		MessageBox.Show("La conexion a la DB: " + connection.Database + " ha sido exitosa.");
        return connection;
    }

    public void ReleaseConnection(SqlConnection connection)
    {
        connection.Close();
		MessageBox.Show("Se ha desconectado correctamente");
        connection.Dispose();
    }
}