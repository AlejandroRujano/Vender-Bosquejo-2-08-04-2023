namespace Vender_Bosquejo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListaProductos_Click(object sender, EventArgs e)
        {
            Form2 ListaDeProductos = new Form2();
            ListaDeProductos.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Form3 NuevoCliente = new Form3();
            NuevoCliente.Show();
        }
    }
}