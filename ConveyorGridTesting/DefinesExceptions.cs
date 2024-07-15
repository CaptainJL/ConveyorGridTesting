using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorGridTesting
{
    public struct GameDefines
    {
        public const int SUBGRID_SIZEPX = 10;
        public const int SUBGRIDS_PER_GRID = 5;
        public const int GRID_X_MAX = 10;
        public const int GRID_Y_MAX = 6;
        // Each grid has 5 sub-grids for allowing movement of items. E.G. A conveyor of 1x1 grid has a 5x5 sub-grid.

        public enum IOState
        {
            None,
            Input,
            Output
        }
        public enum Rotation
        {
            Up,
            Right,
            Down,
            Left
        }
        public enum MovementDirection
        {
            Up,
            Right,
            Down,
            Left
        }
        public enum MovementSpeed  // Sub-grids per second
        {
            Halt = 0,
            Base = 4,
            Double = 8
        }
    }
}
