using System;

namespace projetoLogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita o número de vitórias e derrotas do jogador
            Console.Write("Digite o número de vitórias do jogador: ");
            int vitorias = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de derrotas do jogador: ");
            int derrotas = int.Parse(Console.ReadLine());

            // Calcula o saldo de rankeadas
            int saldoVitorias = CalcularSaldo(vitorias, derrotas);

            // Determina o nível do jogador com base no número de vitórias
            string nivel = ClassificarNivel(vitorias);

            // Exibe a mensagem com o saldo e nível do jogador
            Console.WriteLine($"O Herói tem um saldo de {saldoVitorias} vitórias e está no nível {nivel}");
        }

        static int CalcularSaldo(int vitorias, int derrotas)
        {
            return vitorias - derrotas;
        }

        static string ClassificarNivel(int vitorias)
        {
            if (vitorias < 10)
            {
                return "Ferro";
            }
            else if (vitorias <= 20)
            {
                return "Bronze";
            }
            else if (vitorias <= 50)
            {
                return "Prata";
            }
            else if (vitorias <= 80)
            {
                return "Ouro";
            }
            else if (vitorias <= 90)
            {
                return "Diamante";
            }
            else if (vitorias <= 100)
            {
                return "Lendário";
            }
            else
            {
                return "Imortal";
            }
        }
    }
}

