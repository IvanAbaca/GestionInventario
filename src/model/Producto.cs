using System;
using System.Text;

public class Producto : Vaciable
{
    //ATRIBUTOS
    private static int contadorId = 0;
    private int id;
    private string? nombre;
    private float precio;
    private int cantidad;
    private string? categoria;

    //CONSTRUCTOR
    public Producto(string nombre, float precio, int cantidad, string categoria)
	{
		this.id = ++contadorId;
		this.nombre = nombre;
		this.precio = precio;
		this.cantidad = cantidad;
		this.categoria = categoria;
	}
    //METODOS

    //GETTERS
	public int getId()              { return id; }
	public string? getNombre()       { return nombre; }
	public float getPrecio()        { return precio; }
	public int getCantidad()        { return cantidad; }
	public string? getCategoria()    { return categoria; }

    //SETTERS
	public void setId(int id)                   { this.id = id; }
    public void setNombre(string nombre)        { this.nombre = nombre; }
    public void setPrecio(float precio)         { this.precio = precio; }
    public void setCantidad(int cantidad)       { this.cantidad = cantidad; }
    public void setCategoria(string categoria)  { this.categoria = categoria; }

    //VACIABLE
    public virtual void vaciar()
    {
        id = 0;
        nombre = null;
        precio = 0;
        cantidad = 0;
        categoria = null;
    }

    public virtual bool isVacio()
    {
        return (id == 0 && (nombre == null || nombre.Length == 0) &&
                precio == 0 && cantidad == 0 &&
                (categoria == null || categoria.Length == 0));
    }

    //EQUALS
    public override bool Equals(object? obj)
    {
        return obj is Producto producto &&
               id == producto.id &&
               nombre == producto.nombre &&
               precio == producto.precio &&
               cantidad == producto.cantidad &&
               categoria == producto.categoria;
    }

    //HASHCODE
    public override int GetHashCode()
    {
        return HashCode.Combine(id, nombre, precio, cantidad, categoria);
    }

    //TOSTRING
    public string toString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("id=");
        sb.Append(id);
        sb.Append(" nombre=");
        sb.Append(nombre);
        sb.Append(" precio=");
        sb.Append(precio);
        sb.Append(" cantidad=");
        sb.Append(cantidad);
        sb.Append(" categoria=");
        sb.Append(categoria);
        return sb.ToString();
    }

    //AUTOINCREMENTO


}
