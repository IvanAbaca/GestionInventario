using System;
using System.Text;

public class Cliente : User
{
	//ATRIBUTOS
	private List<Pedido> pedidos;
	//CONSTRUCTOR
	public Cliente(string nombre, int edad, string email, string password, Pedido pedido) : base(nombre, edad, email, password)
	{
		pedidos = new List<Pedido>();
		pedidos.Add(pedido);
		setIsAdmin(false);
	}
	//METODOS
	public void addPedido(Pedido pedido) { this.pedidos.Add(pedido); }
	//GETTERS
	public List<Pedido> getPedidos() { return this.pedidos; }
	//SETTERS
	public void setPedidos(List<Pedido> pedidos) { this.pedidos = pedidos; }
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
    public override string ToString()
    {
		StringBuilder sb = new StringBuilder();
		sb.Append(base.ToString());
		sb.AppendLine("Lista de pedidos: ");
        foreach (Pedido pedido in pedidos)
        {
			sb.AppendLine(pedido.ToString());
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
