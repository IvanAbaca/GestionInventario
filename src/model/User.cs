using System;
using System.Net;
using System.Text;

//CLASE ABSTRACTA USER
public abstract class User : Vaciable
{
    //ATRIBUTOS
	private static int contadorId = 0;
	private int id;
	private string? nombre;
	private int edad;
	private string? email;
	private string? password;
	private bool loginStatus;
    private bool isAdmin;
    private DateTime fechaSesion;
    
    
    //CONSTRUCTOR
	public User(string nombre, int edad, string email, string password)
	{
		this.id = ++contadorId;
        this.nombre = nombre;
        this.edad = edad;
		this.email = email;
		this.password = password;
		this.fechaSesion = DateTime.Now;
	}
    //GETTERS
	public int getId() { return id; }
	public string? getNombre() { return nombre; }
	public int getEdad() { return edad; }
	public string? getEmail() { return email; }
	public string? getPassword() { return password; }
	public bool getLoginStatus() { return loginStatus; }
    public bool getIsAdmin() { return isAdmin; }
	public DateTime getFechaSesion() { return fechaSesion; }
    //SETTERS
	public void setId(int id) { this.id = id; }
	public void setNombre(string nombre) { this.nombre = nombre; }
	public void setEdad(int edad) { this.edad = edad; }
	public void setEmail(string email) { this.email = email; }
	public void setPassword(string password) { this.password = password; }
    public void setLoginStatus(bool loginStatus) { this.loginStatus = loginStatus; }
    public void setIsAdmin(bool isAdmin) { this.isAdmin = isAdmin; }
    public void setDateTime(DateTime fechaSesion) { this.fechaSesion = fechaSesion; }

    //METODOS DE LA INTERFAZ VACIABLE
    public virtual void vaciar()
    {
        id = 0;
        nombre = null;
		edad = 0;
        email = null;
        password = null;
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