using System;

namespace ProjetoElevador
{
    internal class Elevador
    {
        //Variável do andar atual do elevador
        public int AndarAtual;

        //Variável de total de pessoas dentro do elevador
        public int TotalPessoas;

        //Variável que armazena a quantidade de andares do edifício
        public readonly int TotalAndares;

        //Variável que armazena a capacidade máxima do elevador
        public readonly int Capacidade;


        //Construtor de classe responsável por inicializar as variáveis do elevador 
        public Elevador(int capacidade, int andares)
        {
            TotalAndares = andares;
            Capacidade = capacidade;
        }

        //Função responsável por adicionar uma pessoa ao elevador
        public void Entrar()
        {
            if (TotalPessoas < Capacidade)
            {
                TotalPessoas++;
                string exibirQtd = TotalPessoas == 1 ? $"{TotalPessoas} Pessoa entrou no elevador." : $"{TotalPessoas} Pessoas entraram no elevador.";
                Console.WriteLine(exibirQtd);
            }
            else
            {
                Console.WriteLine($"O elevador não permite ultrapassar a capacidade máxima de {Capacidade} pessoas.");
            }
        }

        //Função responsável por remover uma pessoa do elevador
        public void Sair()
        {
            if (TotalPessoas > 0)
            {
                TotalPessoas--;
                Console.WriteLine("Uma pessoa saiu do elevador.");
            }
            else
            {
                Console.WriteLine("O elevador está vazio.");
            }
        }

        //Função responsável pra subir o elevador por andar 
        public void Subir()
        {
            if (AndarAtual < TotalAndares)
            {
                AndarAtual++;
                string exibirAtual = AndarAtual != 0 ? $"O elevador chegou ao {AndarAtual}º andar." : $"Descendo para o {AndarAtual}º andar.";
                Console.WriteLine(exibirAtual);
            }
            else
            {
                Console.WriteLine($"O elevador já está no {AndarAtual}º e último andar!");
            }
        }

        //Função responsável por descer o elevador por andar
        public void Descer()
        {
            if (AndarAtual > 0)
            {
                AndarAtual--;
                string exibirAndar = AndarAtual == 0 ? $"O elevador chegou no térreo." : $"Descendo para o {AndarAtual}º andar.";
                Console.WriteLine(exibirAndar);
            }
            else
            {
                Console.WriteLine("O elevador está no térreo!");
            }
        }
    }
}
