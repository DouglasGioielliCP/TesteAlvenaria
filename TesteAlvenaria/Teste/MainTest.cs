using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAlvenaria.Core;
using TesteAlvenaria.Classes;
using System.IO;

namespace TesteAlvenaria.Teste;


internal class MainTest
{
    public static List<IWallData> RunTest(string path)
    {

        List<IBlockData> blockList = new List<IBlockData>();
        List<IOpeningData> openingList = new List<IOpeningData>();

        try
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    if (line.StartsWith("Bloco"))
                    {
                        // Dividindo a linha pelos delimitadores e removendo espaços em branco
                        string[] values = line.Substring(6).Split('|', StringSplitOptions.RemoveEmptyEntries);

                        int len = int.Parse(values[0]);
                        int x = int.Parse(values[1]);
                        int y = int.Parse(values[2]);
                        int angle = int.Parse(values[3]);

                        int wallPosition = x;
                        int height = 20;
                        int elevation = y;
                        int length = len;

                        // Criando o objeto BlockData e adicionando à lista
                        IBlockData bloco = new BlockData(wallPosition, height, length, elevation);
                        blockList.Add(bloco);
                    }
                    else if (line.StartsWith("Janela"))
                    {
                        // Dividindo a linha pelos delimitadores e removendo espaços em branco
                        string[] values = line.Substring(7).Split('|', StringSplitOptions.RemoveEmptyEntries);

                        int len = int.Parse(values[0]);
                        int height = int.Parse(values[1]);
                        int elevation = int.Parse(values[2]);
                        int x = int.Parse(values[3]);
                        int y = int.Parse(values[4]);
                        int angle = int.Parse(values[5]);

                        IOpeningData janela = new OpeningData(x, height, len, elevation);
                        openingList.Add(janela);
                    }
                    else if (line.StartsWith("Porta"))
                    {
                        // Dividindo a linha pelos delimitadores e removendo espaços em branco
                        string[] values = line.Substring(6).Split('|', StringSplitOptions.RemoveEmptyEntries);

                        int len = int.Parse(values[0]);
                        int height = int.Parse(values[1]);
                        int x = int.Parse(values[2]);
                        int y = int.Parse(values[3]);
                        int angle = int.Parse(values[4]);

                        IOpeningData porta = new OpeningData(x, height, len, 0);
                        openingList.Add(porta);
                    }

                }
            }
            else
            {
                Console.WriteLine("O arquivo especificado não foi encontrado.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {ex.Message}");
        }


        IWallData wall1;
        wall1 = new WallData("Wall1", 0, 0, 90, 500, blockList, openingList);

        return new List<IWallData> { wall1 };
    }
}