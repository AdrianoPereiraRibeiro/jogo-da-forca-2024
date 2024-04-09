

namespace JogoDaForca.ConsoleApp
{
    internal class Forca
    {
        public string palavraSelecionada;
        public char[] separaPalavra, mostraLetra;
        public  int tentativas, pontos;
        public void Switch(char[] mostraLetra, int tentativas)
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

        public void ConvertLetrasTo_(char[] mostraLetra)
        {
            for (int i = 0; i < mostraLetra.Length; i++)
            {
                mostraLetra[i] = '_';
            }
        }

        public void Declarações(out string palavraSelecionada, out char[] separaPalavra, out int tentativas, out char[] mostraLetra, out int pontos)
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

        public void GameOver(int tentativas, char[] mostraLetra)
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

        public void Vitoria()
        {
            Console.WriteLine("GAME WIN!!!!!");
            Console.ReadLine();
        }

        public void ComparaLetras(char[] separaPalavra, ref int tentativas, char[] mostraLetra, ref int pontos, char letraUser, char letraUserMaiscula, ref int aux)
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

        public void DigiteaLetra(string palavraSelecionada, out char letraUser, out char letraUserMaiscula, out int aux)
        {
            Console.WriteLine("Digite uma letra: ");
            letraUser = Convert.ToChar(Console.ReadLine());
            letraUserMaiscula = Char.ToUpper(letraUser);
            Console.WriteLine(palavraSelecionada);
            aux = 0;
        }

        public void Forca1(char[] mostraLetra)
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

        public void Forca2(char[] mostraLetra)
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

        public void Forca3(char[] mostraLetra)
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

        public void Forca4(char[] mostraLetra)
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

        public void Forca5(char[] mostraLetra)
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

