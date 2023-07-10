using System.Data.SqlClient;

namespace GestionInventario
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) { }
        private void addPedidos_Click(object sender, EventArgs e) { }
        private void getPedidos_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) 
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
            /*
            ProductoDAO prodDao = new();
            Pedido pedido = new Pedido();
            pedido.setProductos(prodDao.LeerTodos());
            DatosPedidos.Text = pedido.toString();*/
        }
    }
}