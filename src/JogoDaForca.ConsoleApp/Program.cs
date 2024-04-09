using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forca forca = new Forca();
            forca.Declarações(out forca.palavraSelecionada, out forca.separaPalavra, out forca.tentativas, out forca.mostraLetra, out forca.pontos);
            forca.ConvertLetrasTo_(forca.mostraLetra);

            while (forca.tentativas > 0)
            {
                forca.Switch(forca.mostraLetra, forca.tentativas);
                char letraUser, letraUserMaiscula;
                int aux;
                forca.DigiteaLetra(forca.palavraSelecionada, out letraUser, out letraUserMaiscula, out aux);

                forca.ComparaLetras(forca.separaPalavra, ref forca.tentativas, forca.mostraLetra, ref forca.pontos, letraUser, letraUserMaiscula, ref aux);

                if (forca.pontos == forca.separaPalavra.Length)
                {
                    forca.Vitoria();
                    break;
                }



            }
            forca.GameOver(forca.tentativas, forca.mostraLetra);

        }


    }
}
