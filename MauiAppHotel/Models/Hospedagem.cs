namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime DataChekin { get; set; }
        public DateTime DataChekout { get; set; }

        public int Estadia => DataChekout.Subtract(DataChekin).Days;


        public double ValorTotal
        {
            get
            {

                double valor_adultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valor_criancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;
                double total = (valor_adultos + valor_criancas) * Estadia;

                return total;

            }
        }
    }
}
