using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

public class AdminDAO : DAO<Admin>
{
	public int lastId()
	{
        ConnectionManager con = new ConnectionManager();
        SqlConnection connection = con.GetConnection();
        //Código para leer el dato en la base de datos
        string sql = "SELECT MAX(user_id) FROM usuarios";
        int lastId = 1;
        using (SqlCommand command = new SqlCommand(sql, connection))
            using (SqlDataReader reader = command.ExecuteReader())
                if (reader.Read())
                    lastId = reader.GetInt32(0) + 1;
        con.ReleaseConnection(connection);
        return lastId;
    }

	public void Agregar(Admin admin)
	{
		if (admin == null)
			throw new ArgumentNullException("admin");
        ConnectionManager con = new ();
        SqlConnection connection = con.GetConnection();
		string sql =	"insert into usuarios (user_id, user_nombre, edad, email, password, loginStatus, isAdmin, fechaSesion) values ("
						+ admin.Id + ", '"
						+ admin.Nombre + "',"
						+ admin.Edad + ", '"
						+ admin.Email + "', '"
						+ admin.Password + "',"
						+ (admin.LoginStatus?1:0) + ","
						+ (admin.IsAdmin?1:0) + ", '"
						+ admin.FechaSesion + "')";

		using (SqlCommand command = new (sql, connection))
			command.ExecuteNonQuery();
		con.ReleaseConnection(connection);
    }

	public void Eliminar(Admin admin)
	{
		if (admin == null)
			throw new ArgumentNullException("admin");
		ConnectionManager con = new();
		SqlConnection connection = con.GetConnection();
		string sql = "delete from usuarios where user_id = " + admin.Id;
		using (SqlCommand command = new SqlCommand(sql, connection))
			command.ExecuteNonQuery();
		con.ReleaseConnection(connection);
	}
	public void Modificar(Admin admin)
	{ 
		if (admin == null)  
			throw new ArgumentNullException("admin");
		ConnectionManager con = new();
		SqlConnection connection = con.GetConnection();
		string sql = "update usuarios set user_nombre='" + admin.Nombre + "', edad=" + admin.Edad + ", email='" + admin.Email + "', password='" + admin.Password + "', loginStatus=" + (admin.LoginStatus ? 1 : 0) + ", isAdmin=" + (admin.IsAdmin ? 1 : 0) + ", fechaSesion='" + admin.FechaSesion + "' where user_id =" + admin.Id;
        using (SqlCommand command = new(sql, connection))
			command.ExecuteNonQuery();
		con.ReleaseConnection(connection);
	}
	public Admin Leer(int id)
	{
		if (id < 0)
			throw new ArgumentOutOfRangeException("id");
		ConnectionManager con = new();
		SqlConnection connection = con.GetConnection();
		string sql = "select * from usuarios where user_id =" + id;
		Admin admin = new Admin();
		using (SqlCommand command = new(sql, connection))
            using (SqlDataReader reader = command.ExecuteReader())
				if(reader.Read())
				{
					admin.Id = id;
					admin.Nombre = reader.GetString(1);
					admin.Edad = reader.GetInt32(2);
					admin.Email = reader.GetString(3);
					admin.Password = reader.GetString(4);
					admin.LoginStatus = reader.GetInt32(5) == 1;
					admin.IsAdmin = reader.GetInt32(6) == 1;
					admin.FechaSesion = reader.GetDateTime(7);
				}
		con.ReleaseConnection(connection);
		return admin;
	}
	public List<Admin> LeerTodos()
	{
		ConnectionManager con = new();
		SqlConnection connection = con.GetConnection();
		string sql = "select * from usuarios where isAdmin=" + 1;
		List<Admin> admins = new List<Admin>();
		using (SqlCommand command = new SqlCommand(sql, connection))
			using (SqlDataReader reader = command.ExecuteReader())
				while(reader.Read())
				{
					Admin admin = new Admin();
					admin.Id = reader.GetInt32(0);
                    admin.Nombre = reader.GetString(1);
                    admin.Edad = reader.GetInt32(2);
                    admin.Email = reader.GetString(3);
                    admin.Password = reader.GetString(4);
                    admin.LoginStatus = reader.GetInt32(5) == 1;
                    admin.IsAdmin = reader.GetInt32(6) == 1;
                    admin.FechaSesion = reader.GetDateTime(7);
					admins.Add(admin);
                }
		return admins;
	}
}
