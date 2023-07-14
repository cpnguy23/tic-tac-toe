using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace tic_tac_to
{
    public class tictacto : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch pen;

        public tictacto()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferHeight = 700;         /* windows size */
            _graphics.PreferredBackBufferWidth = 1200;
            
            Texture2D texture;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here


            /*int x = 10;
            int y = 20;
            int width = 30;
            int height = 40;

            Rectangle rectangle = new Rectangle(x, y, width, height);
            System.Console.WriteLine("New Rectangle: (0)", rectangle);*/

            base.Initialize();
        }

        protected override void LoadContent()
        {

            // TODO: use this.Content to load your game content here

            Vector2 position;
            position = new Vector2(100, 100);   //setting draw position
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
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}