using ConveyorGridTesting.GridObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

namespace ConveyorGridTesting
{
    



    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Grid GameGrid;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.IsFullScreen = false;
            _graphics.PreferredBackBufferWidth = GameDefines.GRID_X_MAX * GameDefines.SUBGRIDS_PER_GRID * GameDefines.SUBGRID_SIZEPX;
            _graphics.PreferredBackBufferHeight = GameDefines.GRID_Y_MAX * GameDefines.SUBGRIDS_PER_GRID * GameDefines.SUBGRID_SIZEPX;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            GameGrid = new Grid(GameDefines.GRID_X_MAX, GameDefines.GRID_Y_MAX, Content);
            GameGrid.EnableGridOverlay = true;
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            // TODO: Add your drawing code here
            GameGrid.DrawGridOverlay(_spriteBatch);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}