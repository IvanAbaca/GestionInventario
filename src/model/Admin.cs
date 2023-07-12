using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

public class Admin : User
{
    //CONSTRUCTOR
    public Admin() : base()
    {
        IsAdmin = false;
    }
    public Admin(string nombre, int edad, string email, string password) : base(nombre, edad, email, password)
	{
		IsAdmin = true;
	}
    //METODOS

    /*FALTA DESARROLLAR*/

    //VACIABLE
    public override void vaciar()
    {
        base.vaciar();
        IsAdmin = false;
    }

    public override bool isVacio()
    {
        return (base.isVacio() && IsAdmin == false);
    }
}
