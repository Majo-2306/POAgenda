namespace POAgenda
{
    public partial class Form1 : Form
    {
        private Agenda _agenda;
        public Form1()
        {
            InitializeComponent();
            _agenda = new Agenda();
            DgvContactos.AutoGenerateColumns = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DgvContactos.DataSource = null;


            string nombre = TxtNombre.Text;
            string telefono = TxtTelefono.Text;

            Contacto nuevoContacto = new Contacto(nombre, telefono);



            _agenda.Agregar(nuevoContacto);

            Contacto[] contactos = _agenda.ObtenerContactos();

            DgvContactos.DataSource = contactos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
