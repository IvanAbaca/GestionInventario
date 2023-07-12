using System.Data;
using System.Data.SqlClient;

namespace GestionInventario
{
    public partial class Form1 : Form
    {

        static AdminDAO adminDAO = new AdminDAO();
        static Admin admin = new Admin();
        public Form1() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) { }
        private void addPedidos_Click(object sender, EventArgs e) { }
        private void getPedidos_Click(object sender, EventArgs e) { }


        private void add_btn_Click(object sender, EventArgs e)
        {
            if (admin.LoginStatus)
            {
                ProductoDAO prodDAO = new ProductoDAO();
                Producto prod = new Producto(txtBox_Nombre.Text, float.Parse(txtBox_Precio.Text), int.Parse(txtBox_Cantidad.Text), txtBox_Categoria.Text);
                prodDAO.Agregar(prod);
            }
            else
                MessageBox.Show("No ha iniciado sesion o usted no es admin");
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (admin.LoginStatus && admin.IsAdmin)
            {
                ProductoDAO prodDAO = new ProductoDAO();
                Producto prod = new Producto(txtBox_Nombre.Text, float.Parse(txtBox_Precio.Text), int.Parse(txtBox_Cantidad.Text), txtBox_Categoria.Text);
                prod.Id = int.Parse(txtBox_Id.Text);
                prodDAO.Eliminar(prod);
            }
            else
                MessageBox.Show("No ha iniciado sesion o usted no es admin");
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (admin.LoginStatus && admin.IsAdmin)
            {
                ProductoDAO prodDAO = new ProductoDAO();
                Producto prod = new Producto(txtBox_Nombre.Text, float.Parse(txtBox_Precio.Text), int.Parse(txtBox_Cantidad.Text), txtBox_Categoria.Text);
                prod.Id = int.Parse(txtBox_Id.Text);
                prodDAO.Modificar(prod);
            }
            else
                MessageBox.Show("No ha iniciado sesion o usted no es admin");
        }

        private void read_btn_Click(object sender, EventArgs e)
        {
            if (admin.LoginStatus && admin.IsAdmin)
            {
                ProductoDAO prodDAO = new ProductoDAO();
                Producto prod = prodDAO.Leer(int.Parse(txtBox_Id.Text));
                List<Producto> productos = new List<Producto>();
                productos.Add(prod);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productos;
            }
            else
                MessageBox.Show("No ha iniciado sesion o usted no es admin");
        }

        private void read_all_btn_Click(object sender, EventArgs e)
        {
            if (admin.LoginStatus && admin.IsAdmin)
            {
                ProductoDAO prodDAO = new ProductoDAO();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = prodDAO.LeerTodos();
            }
            else
                MessageBox.Show("No ha iniciado sesion o usted no es admin");
        }

        private void adminbtn_readAll_Click(object sender, EventArgs e)
        {
            if (admin.LoginStatus && admin.IsAdmin)
            {
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = adminDAO.LeerTodos();
            }
            else
                MessageBox.Show("No ha iniciado sesion o usted no es admin");
        }

        private void adminRegister_Click(object sender, EventArgs e)
        {
            Admin createAdmin = new Admin(rAdmin_Nombre.Text, int.Parse(rAdmin_Edad.Text), rAdmin_Email.Text, rAdmin_Password.Text);
            adminDAO.Agregar(createAdmin);
            MessageBox.Show("Se ha registrado correctamente " + rAdmin_Nombre.Text);
        }

        private void adminbtn_read_Click(object sender, EventArgs e)
        {
            if (admin.LoginStatus && admin.IsAdmin)
            {
                List<Admin> admins = new List<Admin>();
                admins.Add(adminDAO.Leer(int.Parse(admin_id.Text)));
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = admins;
            }
            else
                MessageBox.Show("No ha iniciado sesion o usted no es admin");
        }

        private void adminbtn_update_Click(object sender, EventArgs e)
        {
            if (admin.LoginStatus && admin.IsAdmin)
            {
                Admin updateAdmin = new Admin(rAdmin_Nombre.Text, int.Parse(rAdmin_Edad.Text), rAdmin_Email.Text, rAdmin_Password.Text);
                updateAdmin.Id = int.Parse(admin_id.Text);
                adminDAO.Modificar(updateAdmin);
                MessageBox.Show("Se ha modificado correctamente " + rAdmin_Nombre.Text);
            }
            else
            MessageBox.Show("No ha iniciado sesion o usted no es admin");
        }

        private void adminbtn_delete_Click(object sender, EventArgs e)
        {
            if (admin.LoginStatus && admin.IsAdmin)
            {
                Admin deleteAdmin = new Admin(rAdmin_Nombre.Text, int.Parse(rAdmin_Edad.Text), rAdmin_Email.Text, rAdmin_Password.Text);
                deleteAdmin.Id = int.Parse(admin_id.Text);
                adminDAO.Eliminar(deleteAdmin);
                MessageBox.Show("Se ha eliminado correctamente " + rAdmin_Nombre.Text);
            }
            else
                MessageBox.Show("No ha iniciado sesion o usted no es admin");
        }

            private void adminLogIn_Click(object sender, EventArgs e)
        {
            admin = adminDAO.Leer(int.Parse(admin_id.Text));
            if(admin.Email == iAdmin_Email.Text && admin.Password == iAdmin_Password.Text)
            {
                admin.LoginStatus = true;
                MessageBox.Show("Se ha iniciado sesion correctamente.");
            }
            MessageBox.Show("El email o la contraseña es incorrecta.");
        }




        /*private void button2_Click(object sender, EventArgs e)
        {
            //Puerbas para analizar el funcionamiento del DAO
            ProductoDAO prodDao = new();
            Producto prod = new Producto("Yogurt", 100, 1, "Lacteos");
            DatosPedidos.Text = prod.toString();
            prodDao.Agregar(prod);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Puerbas para analizar el funcionamiento del DAO

            ProductoDAO prodDao = new();

            Producto prod = new Producto("Yogurt", 100, 1, "Lacteos");
            prod.setId(1);
            prodDao.Eliminar(prod);
            
            ProductoDAO prodDao = new();
            Pedido pedido = new Pedido();
            pedido.setProductos(prodDao.LeerTodos());
            DatosPedidos.Text = pedido.toString();
        }*/
    }
}