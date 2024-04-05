using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavraSelecionada;
            char[] separaPalavra, mostraLetra;
            int tentativas, pontos;
            Declarações(out palavraSelecionada, out separaPalavra, out tentativas, out mostraLetra, out pontos);
            ConvertLetrasTo_(mostraLetra);

            while (tentativas > 0)
            {
                Switch(mostraLetra, tentativas);
                char letraUser, letraUserMaiscula;
                int aux;
                DigiteaLetra(palavraSelecionada, out letraUser, out letraUserMaiscula, out aux);

                ComparaLetras(separaPalavra, ref tentativas, mostraLetra, ref pontos, letraUser, letraUserMaiscula, ref aux);

                if (pontos == separaPalavra.Length)
                {
                    Vitoria();
                    break;
                }



            }
            GameOver(tentativas, mostraLetra);

        }

        private static void Switch(char[] mostraLetra, int tentativas)
        {
            Console.Clear();
            switch (tentativas)
            {
                case 5:
                    Forca5(mostraLetra);
                    break;
                case 4:
                    Forca4(mostraLetra);
                    break;
                case 3:
                    Forca3(mostraLetra);
                    break;
                case 2:
                    Forca2(mostraLetra);
                    break;
                case 1:
                    Forca1(mostraLetra);
                    break;
            }
        }

        private static void ConvertLetrasTo_(char[] mostraLetra)
        {
            for (int i = 0; i < mostraLetra.Length; i++)
            {
                mostraLetra[i] = '_';
            }
        }

        private static void Declarações(out string palavraSelecionada, out char[] separaPalavra, out int tentativas, out char[] mostraLetra, out int pontos)
        {
            Random aleatorio = new Random();
            string[] frutas = ["ABACATE","ABACAXI","ACEROLA","ACAI","ARACA","BACABA","BACURI","BANANA","CAJU","CARAMBOLA","CUPUACU","GRAVIOLA","GOIABA","JABUTICABA","JENIPAPO","MACA","MANGABA","MANGA","MARACUJA","MURICI","PEQUI",
                "PITANGA","PITAYA","SAPOTI","TANGERINA","UMBU","UVA","UVAIA"];
            int valorFruta = aleatorio.Next(frutas.Length);
            palavraSelecionada = frutas[valorFruta];
            separaPalavra = palavraSelecionada.ToCharArray();
            tentativas = 5;
            mostraLetra = new char[separaPalavra.Length];
            pontos = 0;
        }

        private static void GameOver(int tentativas, char[] mostraLetra)
        {
            if (tentativas == 0)
            {
                Console.Clear();
                Console.WriteLine("____________________" +
                                "\n|/                 o" +
                                "\n|                 |x|" +
                                "\n|                  x" +
                                "\n|                   " +
                                "\n|                   " +
                                "\n|                   " +
                                "\n|_________          ");
                Console.WriteLine(new string(mostraLetra));
                Console.WriteLine("GAME OVER!!!!");
                Console.ReadLine();
            }
        }

        private static void Vitoria()
        {
            Console.WriteLine("GAME WIN!!!!!");
            Console.ReadLine();
        }

        private static void ComparaLetras(char[] separaPalavra, ref int tentativas, char[] mostraLetra, ref int pontos, char letraUser, char letraUserMaiscula, ref int aux)
        {
            for (int i = 0; i < separaPalavra.Length; i++)
            {
                if (separaPalavra[i] == letraUserMaiscula)
                {
                    mostraLetra[i] = letraUser;
                    aux++;
                    pontos++;
                }
            }

            if (aux == 0)
            {
                tentativas--;
            }
        }

        private static void DigiteaLetra(string palavraSelecionada, out char letraUser, out char letraUserMaiscula, out int aux)
        {
            Console.WriteLine("Digite uma letra: ");
            letraUser = Convert.ToChar(Console.ReadLine());
            letraUserMaiscula = Char.ToUpper(letraUser);
            Console.WriteLine(palavraSelecionada);
            aux = 0;
        }

        private static void Forca1(char[] mostraLetra)
        {
            Console.WriteLine("____________________" +
                            "\n|/                 o" +
                            "\n|                 |x|" +
                            "\n|                   " +
                            "\n|                   " +
                            "\n|                   " +
                            "\n|                   " +
                            "\n|_________          ");
            Console.WriteLine(new string(mostraLetra));
        }

        private static void Forca2(char[] mostraLetra)
        {
            Console.WriteLine("____________________" +
                                                    "\n|/                 o" +
                                                    "\n|                 |x" +
                                                    "\n|                   " +
                                                    "\n|                   " +
                                                    "\n|                   " +
                                                    "\n|                   " +
                                                    "\n|_________          ");
            Console.WriteLine(new string(mostraLetra));
        }

        private static void Forca3(char[] mostraLetra)
        {
            Console.WriteLine("____________________" +
                            "\n|/                 o" +
                            "\n|                 | " +
                            "\n|                   " +
                            "\n|                   " +
                            "\n|                   " +
                            "\n|                   " +
                            "\n|_________          ");
            Console.WriteLine(new string(mostraLetra));
        }

        private static void Forca4(char[] mostraLetra)
        {
            Console.WriteLine("____________________" +
                                                    "\n|/                 o" +
                                                    "\n|                   " +
                                                    "\n|                   " +
                                                    "\n|                   " +
                                                    "\n|                   " +
                                                    "\n|                   " +
                                                    "\n|_________          ");
            Console.WriteLine(new string(mostraLetra));
        }

        private static void Forca5(char[] mostraLetra)
        {
            Console.WriteLine("____________________" +
                            "\n|/                  " +
                            "\n|                   " +
                            "\n|                   " +
                            "\n|                   " +
                            "\n|                   " +
                            "\n|                   " +
                            "\n|_________          ");
            Console.WriteLine(new string(mostraLetra));
        }
    }
}
