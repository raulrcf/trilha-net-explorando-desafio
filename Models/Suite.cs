namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
    public int Capacidade { get; set; }
    public int ValorDiaria { get; set; }

    public Suite(int capacidade, int valorDiaria)
    {
        Capacidade = capacidade;
        ValorDiaria = valorDiaria;
    }
}
}