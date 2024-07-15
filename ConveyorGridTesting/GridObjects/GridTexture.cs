using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConveyorGridTesting.GameDefines;

namespace ConveyorGridTesting.GridObjects
{
    internal class GridTexture
    {
        public string TextureLocation { get; protected set; } = null;
        protected Texture2D Texture { get; set; }
        protected int pixelZeroX, pixelZeroY;
        protected int TextureZ = 0;

        public void DrawOverlay(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(Texture, new Vector2(pixelZeroX, pixelZeroY), null, Color.White, MathHelper.ToRadians(90 * 0), new Vector2(0, 0), new Vector2(1, 1), SpriteEffects.None, TextureZ);
            

        }
    }
}
