using System;

namespace ListaStruct_Ex5
{
    class Program
    {
        public struct Trunfo
        {
            public string pais;
            public string nome;
            public string fabricante;
            public double velocidade;
            public int hp;
            public int tempo;
            public int cilindradas;
            public int cilindros;
            public int pesos;
        }

        static void Main(string[] args)
        {
            Trunfo atributo;
            Console.WriteLine("Digite o Pais de Origem do Carro: ");
            atributo.pais = Console.ReadLine();
            Console.WriteLine("Digite Nome do Carro: ");
            atributo.nome = Console.ReadLine();
            Console.WriteLine("Digite o Fabricante do Carro: ");
            atributo.fabricante = Console.ReadLine();
            Console.WriteLine("Digite a Velocidade máxima do Carro: ");
            atributo.velocidade = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o HP do Carro: ");
            atributo.hp = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Tempo de Andar do Carro (De 0 a 100 Km/h): ");
            atributo.tempo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite as Cilindradas: ");
            atributo.cilindradas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os Cilindros: ");
            atributo.cilindros = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Peso do Carro para Finalizar: ");
            atributo.pesos = int.Parse(Console.ReadLine());

            Console.WriteLine("CARTA CONFIRMADA!");
            Console.WriteLine("PAIS: " + atributo.pais);
            Console.WriteLine("NOME: " + atributo.nome);
            Console.WriteLine("FABRICANTE: " + atributo.fabricante);
            Console.WriteLine("VELOCIDADE MÁXIMA: " + atributo.velocidade);
            Console.WriteLine("HP: " + atributo.hp);
            Console.WriteLine("TEMPO DE ANDAR: " + atributo.tempo);
            Console.WriteLine("CILINDRADAS: " + atributo.cilindradas);
            Console.WriteLine("CILINDROS: " + atributo.cilindros);
            Console.WriteLine("PESO: " + atributo.pesos);
        }
    }
}
