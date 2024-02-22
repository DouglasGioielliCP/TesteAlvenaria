using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAlvenaria.Core;
using TesteAlvenaria.Classes;

namespace TesteAlvenaria.Classes;

internal class OpeningData : IOpeningData
{
    public int WallPosition { get; set; }
    public int Height { get; set; }
    public int Length { get; set; }
    public int Elevation { get; set; }

    public OpeningData(int wallPosition, int height, int length, int elevation)
    {
        WallPosition = wallPosition;
        Height = height;
        Length = length;
        Elevation = elevation;
    }
}
