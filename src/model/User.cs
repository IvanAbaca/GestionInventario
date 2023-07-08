using System;
using System.Net;
using System.Text;

//CLASE ABSTRACTA USER
public abstract class User : Vaciable
{
    //DATOS
	private static int contadorId = 0;
	private int id;
	private string nombre;
	private int edad;
	private string email;
	private string password;
	private bool loginStatus;
	private DateTime fechaSesion;
    
    //CONSTRUCTOR
	public User(string pNombre, int pEdad, string pEmail, string pPassword)
	{
		id = lastId();
		nombre = pNombre;
		edad = pEdad;
		email = pEmail;
		password = pPassword;
		fechaSesion = DateTime.Now;
	}
    //GETTERS
	public int getId() { return id; }
	public string getNombre() { return nombre; }
	public int getEdad() { return edad; }
	public string getEmail() { return email; }
	public DateTime getFechaSesion() { return fechaSesion; }
	public string getPassword() { return password; }
	public bool isLoginStatus() { return loginStatus; }
    //SETTERS
	public void setId(int id) { this.id = id; }
	public void setNombre(string nombre) { this.nombre = nombre; }
	public void setEdad(int edad) { this.edad = edad; }
	public void setEmail(string email) { this.email = email; }
	public void setPassword(string password) { this.password = password; }
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
				(password == null || password.Length == 0) && 
				loginStatus == false);
    }

    //ASIGNANDO COMPORTAMIENTO ANTE TOSTRING
    public string toString()
    {
        StringBuilder sb = new StringBuilder("id=");
        sb.Append(id);
        sb.Append(" nombre=");
        sb.Append(nombre);
		sb.Append(" edad=");
		sb.Append(edad);
        sb.Append(" email=");
        sb.Append(email);
        sb.Append(" password=");
        sb.Append(password);
        sb.Append(" loginStatus=");
        sb.Append(loginStatus);
        sb.Append(" fechaSesion=");
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
               fechaSesion == user.fechaSesion;
    }

    //HASHCODE
    public override int GetHashCode()
    {
        return HashCode.Combine(id, nombre, edad, email, password, loginStatus, fechaSesion);
    }
    //AUTOINCREMENTO DE LA ID (ACTUALMENTE HAY QUE MODIFICARLO PARA QUE SE CONECTE CON LA BD)
    public int lastId()
	{
		contadorId++;
		return contadorId;
	}
}