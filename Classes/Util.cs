namespace CadastroPessoaFST2.Classes
{
    public class Util
    {


        /// <summary>
        /// Método para exibir mensagem na barra de carregamento , passar string com a mensagem
        /// </summary>
        /// <param name="msg"></param>
        public static void BarraCarregamento(string msg, int tempo)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write($"{msg}");

            for (var i = 0; i < 6; i++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);

            }

            Console.ResetColor();
        }
    }
}