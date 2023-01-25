using System;
using System.Collections.Generic;
using System.Text;
using DesafioProjetoHospedagem.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int dias = 0;
        int capacidade = 0;
        int valorDiaria = 0;
       
        List<Pessoa> hospedes = new List<Pessoa>();
        Console.WriteLine("Digite o nome do hóspede:");
       
        string nome = Console.ReadLine();
        Pessoa p1 = new Pessoa(nome: nome);
        hospedes.Add(p1);
       
        Console.WriteLine("Adicionar mais um hóspede? (s/n)");
        string opcao = Console.ReadLine();
       
        while (opcao.ToLower() == "s")
        {
            Console.WriteLine("Digite o nome do hóspede:");
            nome = Console.ReadLine();
       
            Pessoa p = new Pessoa(nome: nome);
            hospedes.Add(p);
       
            Console.WriteLine("Adicionar mais um hóspede? (s/n)");
            opcao = Console.ReadLine();
        }
        Console.WriteLine("Digite a quantidade de dias:");
          dias = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Digite a capacidade da suíte:");
            capacidade = Convert.ToInt32(Console.ReadLine());
    
        Console.WriteLine("Digite o valor da diaria:");
            valorDiaria = Convert.ToInt32(Console.ReadLine());
        
        Suite suite = new Suite(capacidade, valorDiaria);
        
        Reserva reserva = new Reserva(dias, hospedes);
        
        if (suite.Capacidade < reserva.ObterQuantidadeHospedes())
        {
            throw new Exception("A suíte escolhida não possui capacidade suficiente para a quantidade de hóspedes.");
        }

       
        Console.WriteLine("Quantidade de hóspedes: " + reserva.ObterQuantidadeHospedes());
        Console.WriteLine("Valor da diária: " + reserva.CalcularValorDiaria(suite));
    }
}
