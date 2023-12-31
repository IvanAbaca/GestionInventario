﻿using System;
using System.Collections.Generic;
using System.Text;

public class Pedido : Vaciable
{
    //ATRIBUTOS
    private static int contadorId = 0;
    private int id_pedido;
    private List<Producto> productos;
    private DateTime fechaEncargo;
	private bool isCerrado;

    //CONSTRUCTOR
    public Pedido()
    {
        id_pedido = ++contadorId;
        productos = new List<Producto>();
        fechaEncargo = DateTime.Now;
        isCerrado = false;
    }
    public Pedido(Producto producto)
	{
		id_pedido = ++contadorId;
		productos = new List<Producto>();
		productos.Add(producto);
		fechaEncargo = DateTime.Now;
		isCerrado = false;
	}
	//METODOS
	public void addProducto(Producto producto) { productos.Add(producto); }
    public void cerrarPedido(Pedido pedido) { pedido.IsCerrado = true; }

    //GETTERS Y SETTERS
    public int IdPedido { get { return id_pedido; } set{ id_pedido = value;} }
	public List<Producto> Productos { get { return productos; } set { productos = value; } }
	public DateTime FechaEncargo { get { return fechaEncargo; } set { fechaEncargo = value; } }
	public bool IsCerrado { get { return isCerrado; } set { isCerrado = value; } }

    //VACIABLE
    public void vaciar()
	{
		id_pedido = 0;
		productos.Clear();
	}

	public bool isVacio()
	{
		return (id_pedido == 0 && productos.Count() == 0);
	}

    //EQUALS
    public override bool Equals(object? obj)
    {
        return obj is Pedido pedido &&
               id_pedido == pedido.id_pedido &&
               EqualityComparer<List<Producto>>.Default.Equals(productos, pedido.productos) &&
               fechaEncargo == pedido.fechaEncargo &&
               isCerrado == pedido.isCerrado;
    }

    //HASHCODE
    public override int GetHashCode()
    {
        return HashCode.Combine(id_pedido, productos, fechaEncargo, isCerrado);
    }

    //TOSTRING
	public string toString()
	{
		StringBuilder sb = new StringBuilder();
        sb.Append("id_pedido=");
        sb.Append(id_pedido);
        sb.Append("\nfechaEncargo=");
        sb.Append(fechaEncargo);
        sb.Append("\nisCerrado=");
        sb.Append(isCerrado);
        sb.AppendLine("\n\nLista de productos: ");
        foreach (Producto producto in productos)
            sb.AppendLine(producto.toString());
        return sb.ToString();
	}

}
