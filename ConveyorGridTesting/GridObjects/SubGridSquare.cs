using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorGridTesting.GridObjects
{
    internal class SubGridSquare : GridTexture
    {
        public SubGridSquare(int x, int y, ContentManager content)
        {
            TextureLocation = "Visuals/Grid/subgrid";
            Texture = content.Load<Texture2D>(TextureLocation);
            TextureZ = 1;
            pixelZeroX = x * GameDefines.SUBGRID_SIZEPX;
            pixelZeroY = y * GameDefines.SUBGRID_SIZEPX;
        }
    }
}
