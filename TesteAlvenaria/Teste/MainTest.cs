using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAlvenaria.Core;
using TesteAlvenaria.Classes;
using System.Windows;
using System.Windows.Controls;

namespace TesteAlvenaria.Teste
{
    internal class MainTest
    {
        public static List<IWallData> RunTest(string path)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                // Criar um novo TextBlock
                TextBlock textBlock = new TextBlock();
                textBlock.Text = "Olá, mundo!";
                textBlock.Margin = new Thickness(5);

                // Localizar o Grid pelo nome
                Grid grid = ((MainWindow)Application.Current.MainWindow).FindName("contentGrid") as Grid;

                // Verificar se o Grid foi encontrado
                if (grid != null)
                {
                    // Adicionar o TextBlock ao Grid
                    Grid.SetRow(textBlock, 7); // Define a linha em que o TextBlock será adicionado
                    Grid.SetColumn(textBlock, 0); // Define a coluna em que o TextBlock será adicionado
                    grid.Children.Add(textBlock); // Adiciona o TextBlock ao Grid
                }
            });

            // Criar um novo objeto BlockData
            IBlockData novoBloco = new BlockData(1, 10, 5, 3);
            return new List<IWallData>();
        }
    }
}