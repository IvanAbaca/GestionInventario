using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

public class ProductoDAO : DAO<Producto>
{

    public int lastId()
    {
        //Lógica para leer el dato de la base de datos
        ConnectionManager con = new ConnectionManager();
        SqlConnection connection = con.GetConnection();
        //Código para leer el dato en la base de datos
        string sql = "SELECT MAX(prod_id) FROM productos";
        int lastId = 1;

        using (SqlCommand command = new SqlCommand(sql, connection))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                    lastId = reader.GetInt32(0) + 1;
            }
        }
        con.ReleaseConnection(connection);
        return lastId;
    }

    public void Agregar(Producto prod)
    {
        ConnectionManager con = new ConnectionManager();
        SqlConnection connection = con.GetConnection();
        // Código para agregar el dato en la base de datos
        string sql = "insert into productos (prod_id, prod_nombre, prod_precio, prod_cantidad, prod_categoria) values(" + prod.getId() + "," + "'" + prod.getNombre() + "'" + "," + prod.getPrecio() + "," + prod.getCantidad() + "," + "'" + prod.getCategoria() + "')";
        using (SqlCommand command = new SqlCommand(sql, connection))
        {
            command.ExecuteNonQuery();
            con.ReleaseConnection(connection);
        }
    }
    public void Eliminar(Producto prod)
    {
        // Lógica para eliminar el dato de la base de datos
        ConnectionManager con = new ConnectionManager();
        SqlConnection connection = con.GetConnection();
        string sql = "delete from productos where prod_id=" + prod.getId();
        using (SqlCommand command = new SqlCommand(sql, connection))
        {
            command.ExecuteNonQuery();
            con.ReleaseConnection(connection);
        }
    }
    public void Modificar(Producto prod)
    {
        ConnectionManager con = new ConnectionManager();
        SqlConnection connection = con.GetConnection();
        // Código para modificar el dato en la base de datos
        string sql = "UPDATE productos SET prod_nombre = '" + prod.getNombre() + "', prod_precio = " + prod.getPrecio() + ", prod_cantidad = " + prod.getCantidad() + ", prod_categoria = '" + prod.getCategoria() + "' WHERE prod_id = " + prod.getId();
        using (SqlCommand command = new SqlCommand(sql, connection))
        {
            command.ExecuteNonQuery();
            con.ReleaseConnection(connection);
        }
    }
    public Producto Leer(int id)
    {
        //Lógica para leer el dato de la base de datos
        ConnectionManager con = new ConnectionManager();
        SqlConnection connection = con.GetConnection();
        //Código para leer el dato en la base de datos
        string sql = "select * from productos where prod_id=" + id;
        Producto prod = new Producto();

        using (SqlCommand command = new SqlCommand(sql, connection))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    prod.setId(reader.GetInt32(0));
                    prod.setNombre(reader.GetString(1));
                    prod.setPrecio((float)reader.GetDouble(2));
                    prod.setCantidad(reader.GetInt32(3));
                    prod.setCategoria(reader.GetString(4));
                }
            }
        }
        con.ReleaseConnection(connection);
        return prod;
    }
    public List<Producto> LeerTodos()
    {
        //Lógica para leer todos los datos de la base de datos
        ConnectionManager con = new ConnectionManager();
        List<Producto> productos = new List<Producto>();
        string sql = "select * from productos";
        using (SqlConnection connection = con.GetConnection())
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Producto prod = new Producto();
                        prod.setId(reader.GetInt32(0));
                        prod.setNombre(reader.GetString(1));
                        prod.setPrecio((float)reader.GetDouble(2));
                        prod.setCantidad(reader.GetInt32(3));
                        prod.setCategoria(reader.GetString(4));
                        productos.Add(prod);
                    }
                }
            }
            con.ReleaseConnection(connection);
        }
        return productos;
    }
}
