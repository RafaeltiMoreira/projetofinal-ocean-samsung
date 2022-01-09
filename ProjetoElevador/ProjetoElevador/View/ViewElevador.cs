using System;

namespace ProjetoElevador.View
{
    internal class ViewElevador
    {

        //Método de exibição do menu de opções para o usuário
        public void Projeto(Elevador elevador)
        {
            var continuar = true;

            while (continuar) 
            {
                Console.WriteLine($@"
                    Quantidade de andares do edifício: { elevador.TotalAndares } { Environment.NewLine }
                    Capacidade máxima permitida no elevador ao subir ou descer: { (elevador.Capacidade <= 1 ? elevador.Capacidade + " pessoa" : elevador.Capacidade + " pessoas") } { Environment.NewLine }
                    Quantidade atual de pessoa (as) no elevador: { (elevador.TotalPessoas <= 1 ? elevador.TotalPessoas + " pessoa" : elevador.TotalPessoas + " pessoas") } { Environment.NewLine }
                    Andar Atual: { (elevador.AndarAtual == 0 ? "Térreo" : elevador.AndarAtual + "º" ) } { Environment.NewLine } 
                    Escolha e informe uma das opções do elevador: { Environment.NewLine }
                    1 - Entrar no elevador
                    2 - Sair do elevador
                    3 - Subir um andar 
                    4 - Descer um andar 
                    5 - Finalizar o simulador
                ");

                var opcao = Console.ReadLine();
                Console.Clear();


                switch (opcao)
                {
                    case "1":
                        elevador.Entrar();
                        break;
                    case "2":
                        elevador.Sair();
                        break;
                    case "3":
                        elevador.Subir();
                        break;
                    case "4":
                        elevador.Descer();
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção não é válida, informe apenas os números das opções.");
                        break;
                }
            }
        }
    }
}
