using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace monogame_1___adding_content
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D dinoTexture, birdTexture, birdTextureTwo, turtleTexture, magpieTexture;
        Random generator = new Random();
        int beep, boop;
        Vector2 pleaseworkohmygod;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            beep = generator.Next(50, 250);
            boop = generator.Next(50, 250);
            pleaseworkohmygod = new Vector2(beep, boop);

            this.Window.Title = "The Cohesive Image Is That I Gave Up";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            dinoTexture = Content.Load<Texture2D>("dino");
            birdTexture = Content.Load<Texture2D>("bird");
            birdTextureTwo = Content.Load<Texture2D>("bird2");
            turtleTexture = Content.Load<Texture2D>("turtle");
            magpieTexture = Content.Load<Texture2D>("halocenepixil");
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
            GraphicsDevice.Clear(Color.MediumPurple);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(dinoTexture, new Vector2(250, 100), Color.White);
            _spriteBatch.Draw(birdTexture, new Vector2(100, 100), Color.White);
            _spriteBatch.Draw(birdTextureTwo, new Vector2(500, 10), Color.White);
            _spriteBatch.Draw(turtleTexture, new Vector2(300, 250), Color.White);
            _spriteBatch.Draw(magpieTexture, pleaseworkohmygod, Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}