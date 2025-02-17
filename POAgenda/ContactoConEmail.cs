namespace POAgenda
{
    //el constructor es un metodo especial, se debe llamar igual que la clase
    class ContactoConEmail : Contacto
    {
        public ContactoConEmail(string nombre, string telefono) 
            : base(nombre, telefono)

        {
        }
    }
}
