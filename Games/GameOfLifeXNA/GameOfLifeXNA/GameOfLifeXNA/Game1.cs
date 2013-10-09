using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Storage;

namespace GameOfLifeXNA
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        private int xsize = 200;
        private int ysize = 200;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D white;
        private Texture2D black;
        public Boolean[][] grid;
        private SpriteFont font;
        private int wpix;
        private int hpix;
        private Matrix spritescale;
        private float screenscale;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            grid = new Boolean[xsize][];
            Populate();
            this.TargetElapsedTime = TimeSpan.FromSeconds(1.0f / 8.0f);
            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 800;
            


            w = GraphicsDevice.Viewport.Width;
            h = GraphicsDevice.Viewport.Height;

            Window.AllowUserResizing = true;
            wpix = 4;// w / ysize;
            hpix = 4;//h/xsize;
            ///Window.ClientSizeChanged += new EventHandler<EventArgs>(Window_ClientSizeChanged);
           
            this.graphics.IsFullScreen = true;
            graphics.ApplyChanges();
            font = Content.Load<SpriteFont>("Statfont");
            base.Initialize();
        }
        void Window_ClientSizeChanged(object sender, EventArgs e)
        {
            w = GraphicsDevice.Viewport.Width;
            h = GraphicsDevice.Viewport.Height;
            graphics.PreferredBackBufferHeight = h;
            graphics.PreferredBackBufferWidth = w;
            Window.AllowUserResizing = true;
            wpix = w / ysize;
            hpix = h / xsize;
            Console.WriteLine(h);
            // Make changes to handle the new window size.
        }
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            float screenscale = graphics.GraphicsDevice.Viewport.Width / 800f;
            spritescale = Matrix.CreateScale(screenscale, screenscale, 1);

            black = Content.Load<Texture2D>("Black");
            white = Content.Load<Texture2D>("White");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Enter) && (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.LeftAlt) || Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.RightAlt)) && !Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.RightAlt))
            {
                graphics.ToggleFullScreen();
               // gameWorld.Refresh();
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                graphics.PreferredBackBufferHeight = 600;
                graphics.PreferredBackBufferWidth = 800;
                screenscale =
            (float)graphics.GraphicsDevice.Viewport.Width / 800f;
                graphics.ApplyChanges();
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                graphics.PreferredBackBufferHeight = 768;
                graphics.PreferredBackBufferWidth = 1024;
                screenscale =
            (float)graphics.GraphicsDevice.Viewport.Width / 1024f;
                graphics.ApplyChanges();
            }
             
            // Create the scale transform for Draw. 
            // Do not scale the sprite depth (Z=1).
            spritescale = Matrix.CreateScale(screenscale, screenscale, 1);

            aliveCells = GameTiem();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            
            spriteBatch.Begin(0, null, null, null, null, null, spritescale);
            
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j])
                    {
                        spriteBatch.Draw(black, new Rectangle(i*wpix, j*hpix, wpix, hpix), Color.Black);
                    }
                    else
                    {
                        spriteBatch.Draw(white, new Rectangle(i * wpix, j * hpix, wpix, hpix), Color.White);
                    }
                }
            }

            spriteBatch.DrawString(font, "Levende celler: " + aliveCells, new Vector2(10, 20), Color.Black);

                spriteBatch.End();

            base.Draw(gameTime);
        }


        public static int mod(int x, int m)
        {
            m = Math.Abs(m);
            return (x % m + m) % m;
        }


        private void Populate()
        {
            var r = new Random();
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = new Boolean[ysize];
                for (int j = 0; j < grid[i].Length; j++)
                {
                    int l = r.Next(0, 8);
                    grid[i][j] = new Boolean();
                    grid[i][j] = (l == 0) ? true : false;
                    
                }
            }
        }

        private int CheckCell(int x, int y)
        {
            int antall = 0;


            if (grid[mod(x + 1, xsize)][y])
            {
                antall++;
            }
            if (grid[mod(x + 1, xsize)][mod(y + 1, ysize)])
            {
                antall++;
            }
            if (grid[x][mod(y + 1, ysize)])
            {
                antall++;
            }
            if (grid[x][mod(y - 1, ysize)])
            {
                antall++;
            }
            if (grid[mod(x + 1, xsize)][mod(y - 1, ysize)])
            {
                antall++;
            }
            if (grid[mod(x - 1, xsize)][y])
            {
                antall++;
            }
            if (grid[mod(x - 1, xsize)][mod(y - 1, ysize)])
            {
                antall++;
            }
            if (grid[mod(x - 1, xsize)][mod(y + 1, ysize)])
            {
                antall++;
            }


            return antall;

        }

        private int GameTiem()
        {
            int alive = 0;
            Boolean[][] temp = new Boolean[xsize][];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = new Boolean[ysize];
                for (int j = 0; j < temp[i].Length; j++)
                {
                    temp[i][j] = new Boolean();
                }
            }

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    temp[i][j] = grid[i][j];
                    int antall = CheckCell(i, j);
                    if (antall == 3 && !grid[i][j])
                    {
                        temp[i][j] = true;
                    }
                    if (grid[i][j] && (antall < 2 || antall > 3))
                    {
                        temp[i][j] = false;
                    }
                    if (temp[i][j])
                    {
                        alive++;
                    }
                }
            }
            grid = temp;
            return alive;
        }

        public int aliveCells { get; set; }

        public int h { get; set; }

        public int w { get; set; }
    }
}
