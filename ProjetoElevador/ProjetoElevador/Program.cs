using ProjetoElevador.Controller;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controllerElevador = new ControllerElevador();

            controllerElevador.Initial();
        }
    }
}
