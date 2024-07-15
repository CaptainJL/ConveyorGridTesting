using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorGridTesting.GridObjects
{

    internal class Grid : GridTexture
    {
        private GridSquare[,] _grid;
        private SubGridSquare[,] _subGrid;
        public bool EnableGridOverlay { get; set; } = false;

        public Grid(int gridX, int gridY, ContentManager content) 
        {
            // Initialise Grid
            _grid = new GridSquare[gridX, gridY];
            for (int x = 0; x < gridX; x++)
            {
                for (int y = 0; y < gridY; y++)
                {
                    _grid[x, y] = new GridSquare(x, y, content);
                }
            }

            // Initalise SubGrid
            _subGrid = new SubGridSquare[gridX * GameDefines.SUBGRID_SIZEPX, gridY * GameDefines.SUBGRID_SIZEPX];
            for (int x = 0; x < (gridX * GameDefines.SUBGRIDS_PER_GRID); x++)
            {
                for (int y = 0; y < (gridY * GameDefines.SUBGRIDS_PER_GRID); y++)
                {
                    _subGrid[x, y] = new SubGridSquare(x, y, content);
                }
            }
        }

        public void DrawGridOverlay(SpriteBatch _spriteBatch)
        {
            if (EnableGridOverlay)
            {
                for (int x = 0; x < (GameDefines.GRID_X_MAX * GameDefines.SUBGRIDS_PER_GRID); x++)
                {
                    for (int y = 0; y < (GameDefines.GRID_Y_MAX * GameDefines.SUBGRIDS_PER_GRID); y++)
                    {
                        _subGrid[x, y].DrawOverlay(_spriteBatch);
                    }
                }
                int ctr = 0;
                for (int x = 0; x < GameDefines.GRID_X_MAX; x++)
                {
                    for (int y = 0; y < GameDefines.GRID_Y_MAX; y++)
                    {
                        _grid[x, y].DrawOverlay(_spriteBatch);
                        ctr++;
                    }
                }
            }
        }

    }
}
