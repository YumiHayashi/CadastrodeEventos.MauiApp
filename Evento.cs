namespace CadastroEventos
{
    public partial class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Propriedade calculada para a duração do evento
        public int DuracaoEmDias => (DataTermino - DataInicio).Days;

        // Propriedade calculada para o custo total do evento
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}