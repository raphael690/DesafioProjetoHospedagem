using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa( nome: "Hospede 1");
Pessoa p2 = new Pessoa( nome: "Hospede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suite
Suite suite = new Suite (tipoSuite: "Premium", capacidade: 3, valorDiaria:25);

// Cria uma nova reserva, passando a suite e os hospedes
Reserva reserva = new Reserva(diasReservados:5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

//Existe a quantidade de hospedes e o valor da diária
Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diaria: {reserva.CalcularValorDiaria()}");






/*
public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Solicita a quantidade de dias reservados
        Console.Write("Digite a quantidade de dias reservados: ");
        int diasReservados = int.Parse(Console.ReadLine());

        // Solicita a quantidade de hóspedes
        Console.Write("Digite a quantidade de hóspedes: ");
        int quantidadeHospedes = int.Parse(Console.ReadLine());

        // Cria a lista de hóspedes dinamicamente
        List<Pessoa> hospedes = new List<Pessoa>();
        for (int i = 0; i < quantidadeHospedes; i++)
        {
            Console.Write($"Digite o nome do hóspede {i + 1}: ");
            string nome = Console.ReadLine();
            hospedes.Add(new Pessoa(nome));
        }

        // Cria a suite (ajustar os valores conforme necessário)
        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 25.0m);

        // Cria uma nova reserva, passando a suite e os hóspedes
        Reserva reserva = new Reserva(diasReservados: diasReservados);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        // Exibe a quantidade de hóspedes e o valor da diária
        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");
    }
}*/