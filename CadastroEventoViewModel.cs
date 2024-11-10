namespace CadastroEventos
{
    using System.Windows.Input;
    using Microsoft.Maui.Controls;

    public class CadastroEventoViewModel : BindableObject
    {
        public Evento Evento { get; set; } = new Evento();

        public ICommand SalvarEventoCommand { get; }

        public CadastroEventoViewModel()
        {
            SalvarEventoCommand = new Command(SalvarEvento);
        }

        private async void SalvarEvento()
        {
            // Navegar para a página de resumo e passar os dados do evento
            await Application.Current.MainPage.Navigation.PushAsync(new ResumoEventoPage(Evento));
        }
    }
}

