using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAlvenaria.Core;
using TesteAlvenaria.Classes;

namespace TesteAlvenaria.Teste;


internal class MainTest
{
    public static List<IWallData> RunTest(string path)
    {
        
        IBlockData bloco1 = new BlockData(40, 0, 000, 0);
        IBlockData bloco2 = new BlockData(40, 0, 040, 0);

        List<IBlockData> blockList = new List<IBlockData>();

        blockList.Add(bloco1);
        blockList.Add(bloco2);

        IOpeningData open1 = new OpeningData(300, 200, 80, 0);

        List<IOpeningData> openingList = new List<IOpeningData>();


        IWallData wall1 = new WallData("Wall1", 0, 0, 90, 500, blockList, openingList);

        return new List<IWallData> { wall1 };
    }
}