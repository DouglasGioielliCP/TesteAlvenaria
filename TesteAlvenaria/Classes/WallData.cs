using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAlvenaria.Core;
using TesteAlvenaria.Classes;

namespace TesteAlvenaria.Classes;


internal class WallData : IWallData
{
	public WallData(string name, int pointX, int pointY, int angle, int length, List<IBlockData> blocks, List<IOpeningData> openings)
	{
		Name = name;
		PointX = pointX;
		PointY = pointY;
		Angle = angle;
		Length = length;
		Blocks = blocks;
		Openings = openings;
	}

	public string Name { get; private set; }
	public int PointX { get; private set; }
	public int PointY { get; private set; }
	public int Angle { get; private set; }
	public int Length { get; private set; }
	public List<IBlockData> Blocks { get; private set; }
	public List<IOpeningData> Openings { get; private set; }
}
