namespace POAgenda
{
    //form1 clase, los : dice que heredan de Form1 a form, form es un formulario
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

           // Contacto nuevoContacto = new Contacto(nombre, telefono);
            ContactoConEmail nuevoContactoConEmail = new ContactoConEmail(nombre, telefono);



            //_agenda.Agregar(nuevoContacto);
            _agenda.Agregar(nuevoContactoConEmail);

            Contacto[] contactos = _agenda.ObtenerContactos();

            DgvContactos.DataSource = contactos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
