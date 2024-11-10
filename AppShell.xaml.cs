namespace CadastroEventos
{
    public partial class App : Application

    { }
        namespace CadastroEventos
    {
        public partial class CadastroEventoPage : ContentPage
        {
            public CadastroEventoPage()
            {
               
                BindingContext = new CadastroEventoViewModel();
            }
        }
    }
}

