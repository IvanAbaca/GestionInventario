using System;
using System.Text;

public class Cliente : User
{
	//ATRIBUTOS
	private List<Pedido> pedidos;
	//CONSTRUCTOR
	public Cliente(string nombre, int edad, string email, string password) : base(nombre, edad, email, password)
	{
		pedidos = new List<Pedido>();
		IsAdmin = false;
	}
	//METODOS
	public void addPedido(Pedido pedido) { this.pedidos.Add(pedido); }
    //GETTERS Y SETTERS
    public List<Pedido> Pedidos { get { return pedidos; } set { pedidos = value; } }
	//VACIABLE
	public override void vaciar()
	{
		base.vaciar();
		this.pedidos.Clear();
	}

    public override bool isVacio()
    {
        return (base.isVacio() && this.pedidos.Count() == 0);
    }

    //TOSTRING
    public override string toString()
    {
		StringBuilder sb = new StringBuilder();
		sb.Append(base.toString());
		sb.AppendLine("\n\nLista de pedidos: ");
        foreach (Pedido pedido in pedidos)
        {
			sb.AppendLine(pedido.toString());
        }
        return sb.ToString();
    }
	//EQUALS
    public override bool Equals(object? obj)
    {
        return obj is Cliente cliente &&
               base.Equals(obj) &&
               EqualityComparer<List<Pedido>>.Default.Equals(pedidos, cliente.pedidos);
    }
	//HASHCODE
    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), pedidos);
    }
}
