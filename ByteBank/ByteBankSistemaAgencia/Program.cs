using System;
using ByteBank.ByteBankModelos;

namespace ByteBank.ByteBankSistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();

            idades.AdicionarVarios(63, 15, 21, 50);
            idades.Remover(15);

            Lista<string> cursos = new Lista<string>();
            cursos.AdicionarVarios("C# Parte 1", "C# Parte 2", "C# Parte 3");

            Lista<ContaCorrente> contas = new Lista<ContaCorrente>();
            contas.AdicionarVarios(new ContaCorrente(124, 54354), new ContaCorrente(201, 44354));

            Console.WriteLine($"Lista de Idades: {idades}");
            Console.WriteLine($"Lista de Cursos: {cursos}");
            Console.WriteLine($"Lista de Contas: {contas}");

            Console.ReadLine();

        }
        static void TestandoAdicionarVarios()
        {

            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.AdicionarVarios(
                new ContaCorrente(100, 40010),
                new ContaCorrente(101, 40011)
            );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente conta = lista.GetItemNoIndice(i);
                Console.WriteLine($"{conta.Agencia}/{conta.Numero}");
            }

        }

        static void TestandoListaDeContas()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente conta = new ContaCorrente(111, 1111);

            lista.Adicionar(conta);
            lista.Adicionar(new ContaCorrente(345, 23462));
            lista.Adicionar(new ContaCorrente(363, 22451));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(333, 23552));
            lista.Adicionar(new ContaCorrente(456, 65423));
            lista.Adicionar(new ContaCorrente(654, 87457));
            lista.Adicionar(new ContaCorrente(334, 97348));
            lista.Adicionar(new ContaCorrente(678, 65899));
            lista.Adicionar(new ContaCorrente(735, 12223));
            lista.Adicionar(new ContaCorrente(735, 98576));
            lista.Adicionar(new ContaCorrente(735, 53534));
            lista.Adicionar(new ContaCorrente(735, 56253));
            lista.Adicionar(new ContaCorrente(735, 43657));
            lista.Adicionar(new ContaCorrente(735, 77534));
            lista.Adicionar(new ContaCorrente(735, 34436));
            lista.Adicionar(new ContaCorrente(735, 98867));

            lista.EscreverListaNaTela();
            Console.WriteLine("conta removida");
            lista.Remover(conta);
            lista.EscreverListaNaTela();
            Console.ReadLine();
        }
    }
}
