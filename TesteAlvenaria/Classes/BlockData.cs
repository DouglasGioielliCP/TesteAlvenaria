using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAlvenaria.Core;
using TesteAlvenaria.Classes;

namespace TesteAlvenaria.Classes;
internal class BlockData : IBlockData

{
    public int WallPosition { get; private set; }
    public int Height { get; private set; }
    public int Length { get; private set; }
    public int Elevation { get; private set; }


    

    public BlockData(int wallPosition, int height, int length, int elevation)
    {
        WallPosition = wallPosition;
        Height = height;
        Length = length;
        Elevation = elevation;
    }
}
