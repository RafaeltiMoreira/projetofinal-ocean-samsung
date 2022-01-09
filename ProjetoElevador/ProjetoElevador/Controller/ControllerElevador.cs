using ProjetoElevador.View;
using System;

namespace ProjetoElevador.Controller
{
    internal class ControllerElevador
    {
        //Método de inicialização
        public void Initial()
        {
            Console.WriteLine(" -------- Bem vindos (as) ao Projeto Elevador -------- ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==> Informe a quantidade de andares do edifício <==");
            Console.WriteLine();
            Console.Write("Quantidade de andares: ");
            var andares = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("==> Informe a capacidade de pessoas permitidas no elevador <==");
            Console.WriteLine();
            Console.Write("Quantidade de pessoas permitidas no elevador: ");
            var capacidade = int.Parse(Console.ReadLine());

            Console.Clear();

            var elevador = new Elevador(capacidade, andares);

            var elevadorView = new ViewElevador();

            elevadorView.Projeto(elevador);
        }

    }
}
