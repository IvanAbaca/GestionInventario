using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

public class Admin : User
{
	//CONSTRUCTOR
	public Admin(string nombre, int edad, string email, string password) : base(nombre, edad, email, password)
	{
		setIsAdmin(true);
	}
    //METODOS

    /*FALTA DESARROLLAR*/


    //VACIABLE
    public override void vaciar()
    {
        base.vaciar();
        setIsAdmin(false);
    }

    public override bool isVacio()
    {
        return (base.isVacio() && getIsAdmin() == false);
    }
}
