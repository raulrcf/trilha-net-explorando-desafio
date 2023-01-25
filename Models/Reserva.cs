namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public int Dias { get; set; }
        public List<Pessoa> Hospedes { get; set; }

        public Reserva(int dias, List<Pessoa> hospedes)
        {
            Dias = dias;
            Hospedes = hospedes;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public double CalcularValorDiaria(Suite suite)
        {
            double valor = suite.ValorDiaria * Dias;
                if (Dias >= 10)
                {
                    valor = valor - (valor * 0.1);
                }
            return valor;
        }
    }
}