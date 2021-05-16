using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSeries
{
    public static class Util
    {

        public static void CarregarCadastros<T>(List<T> lista)
        {
            string arquivo = Environment.CurrentDirectory + @"\Dados\CadastroSeries.txt";

            if (File.Exists(arquivo))
            {
                try
                {
                    using StreamReader sr = new(arquivo);

                    String linha;
                    // Lê linha por linha até o final do arquivo
                    while ((linha = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine(" O arquivo " + arquivo + "não foi localizado !");
            }

            Console.ReadKey();
        }

        private static void CriarDiretorio()
        {
            var diretorioDados = Environment.CurrentDirectory + "\\Dados";

            if (!Directory.Exists(diretorioDados))
                Directory.CreateDirectory(diretorioDados);
        }

        public static void SalvarDadosTXT<T>(T objeto)
        {
            CriarDiretorio();

            //usando a instrução using os recursos são liberados após a conclusão da operação
            using StreamWriter writer = new(Environment.CurrentDirectory + @"\Dados\CadastroSeries.txt", true);

            writer.WriteLine(objeto.ToString());
        }
    }
}
