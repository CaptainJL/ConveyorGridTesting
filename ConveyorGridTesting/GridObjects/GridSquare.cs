using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorGridTesting.GridObjects
{
    internal class GridSquare : GridTexture
    {
        public GridSquare(int x, int y, ContentManager content)
        {
            TextureLocation = "Visuals/Grid/grid";
            Texture = content.Load<Texture2D>(TextureLocation);
            TextureZ = 1;
            pixelZeroX = x * GameDefines.SUBGRIDS_PER_GRID * GameDefines.SUBGRID_SIZEPX;
            pixelZeroY = y * GameDefines.SUBGRIDS_PER_GRID * GameDefines.SUBGRID_SIZEPX;
        }
    }
}
