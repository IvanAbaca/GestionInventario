using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Net;
using System.Text;

//CLASE ABSTRACTA USER
public abstract class User : Vaciable
{
    //ATRIBUTOS
	private int id;
	private string nombre;
	private int edad;
	private string email;
	private string password;
	private bool loginStatus;
    private bool isAdmin;
    private DateTime fechaSesion;


    //CONSTRUCTOR
    public User()
    {
        AdminDAO user = new AdminDAO();
        id = user.lastId();
        nombre = "";
        edad = 0;
        email = "";
        password = "";
        loginStatus = false;
    }
    public User(string nombre, int edad, string email, string password)
	{
        AdminDAO user = new AdminDAO();
        this.id = user.lastId();
        this.nombre = nombre;
        this.edad = edad;
		this.email = email;
		this.password = password;
		this.fechaSesion = DateTime.Now;
        loginStatus = false;
	}
    //GETTERS Y SETTERS

    public int Id { get { return id; } set { id = value; } }
    public string Nombre { get { return nombre; } set { nombre = value; } }
    public int Edad { get { return edad; } set { edad = value; } }
    public string Email { get { return email; } set { email = value; } }
    public string Password { get { return password; } set { password = value; } }
    public bool LoginStatus { get { return loginStatus; } set { loginStatus = value; } }
    public bool IsAdmin { get { return isAdmin; } set { isAdmin = value; } }
    public DateTime FechaSesion{ get { return fechaSesion; } set { fechaSesion = value; } }

    //METODOS DE LA INTERFAZ VACIABLE
    public virtual void vaciar()
    {
        id = 0;
        nombre = "";
		edad = 0;
        email = "";
        password = "";
		loginStatus = false;
    }

    public virtual bool isVacio()
    {
        return	(id == 0 && (nombre == null || nombre.Length == 0) && 
				edad == 0 && (email == null || email.Length == 0) && 
				(password == null || password.Length == 0));
    }

    //ASIGNANDO COMPORTAMIENTO ANTE TOSTRING
    public virtual string toString()
    {
        StringBuilder sb = new StringBuilder("id=");
        sb.Append(id);
        sb.Append("\nnombre=");
        sb.Append(nombre);
		sb.Append("\nedad=");
		sb.Append(edad);
        sb.Append("\nemail=");
        sb.Append(email);
        sb.Append("\npassword=");
        sb.Append(password);
        sb.Append("\nloginStatus=");
        sb.Append(loginStatus);
        sb.Append("\nisAdmin=");
        sb.Append(isAdmin);
        sb.Append("\nfechaSesion=");
        sb.Append(fechaSesion);
        return sb.ToString();
    }

    //EQUALS
    public override bool Equals(object? obj)
    {
        return obj is User user &&
               id == user.id &&
               nombre == user.nombre &&
               edad == user.edad &&
               email == user.email &&
               password == user.password &&
               loginStatus == user.loginStatus &&
               isAdmin == user.isAdmin &&
               fechaSesion == user.fechaSesion;
    }

    //HASHCODE
    public override int GetHashCode()
    {
        return HashCode.Combine(id, nombre, edad, email, password, loginStatus, isAdmin, fechaSesion);
    }
    //AUTOINCREMENTO DE LA ID (ACTUALMENTE HAY QUE MODIFICARLO PARA QUE SE CONECTE CON LA BD)
}