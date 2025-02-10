namespace POAgenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contacto primerContacto = new Contacto("Mariajose", "6221194956");
            MessageBox.Show($"El telefono de  {primerContacto.Nombre} es : {primerContacto.Telefono}");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtNombre.Text + " - " + TxtTelefono.Text);
        }
    }
}
