using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakey
{
    public partial class SnakeGame : Form
    {
        private List<Circle> Snake = new List<Circle>(); // creating an list array for the snake
        private Circle food = new Circle(); // creating a single Circle class called food
        public SnakeGame()
        {
            InitializeComponent();

            new Settings(); // linking the Settings Class to this Form

            gameTimer.Interval = 1000 / Settings.Speed; // Changing the game time to settings speed
            gameTimer.Tick += updateScreen; // linking an updateScreen function to the timer
            gameTimer.Start(); // starting the timer

            startGame(); // running the start game function
        }
        private void updateScreen(object sender, EventArgs e)
        {
            // this is the Timers update screen function. 
            // each tick will run this function

            if (Settings.GameOver == true)
            {

                // if the game over is true and player presses enter
                // we run the start game function

                if (Input.KeyPress(Keys.Enter))
                {
                    startGame();
                }
            }
            else
            {
                //if the game is not over then the following commands will be executed

                // below the actions will probe the keys being presse by the player
                // and move the accordingly

                if (Input.KeyPress(Keys.Right) && Settings.direction != Directions.Left)
                {
                    Settings.direction = Directions.Right;
                }
                else if (Input.KeyPress(Keys.Left) && Settings.direction != Directions.Right)
                {
                    Settings.direction = Directions.Left;
                }
                else if (Input.KeyPress(Keys.Up) && Settings.direction != Directions.Down)
                {
                    Settings.direction = Directions.Up;
                }
                else if (Input.KeyPress(Keys.Down) && Settings.direction != Directions.Up)
                {
                    Settings.direction = Directions.Down;
                }

                movePlayer(); // run move player function
            }

            pbCanvas.Invalidate(); // refresh the picture box and update the graphics on it

        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void UpdateGraphics(object sender, PaintEventArgs e)
        {

        }
        private void startGame()
        {

        }

        private void movePlayer()
        {
            // the main loop for the snake head and parts
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                // if the snake head is active 
                if (i == 0)
                {
                    // move rest of the body according to which way the head is moving
                    switch (Settings.direction)
                    {
                        case Directions.Right:
                            Snake[i].X++;
                            break;
                        case Directions.Left:
                            Snake[i].X--;
                            break;
                        case Directions.Up:
                            Snake[i].Y--;
                            break;
                        case Directions.Down:
                            Snake[i].Y++;
                            break;
                    }

                    // restrict the snake from leaving the canvas
                    int maxXpos = pbCanvas.Size.Width / Settings.Width;
                    int maxYpos = pbCanvas.Size.Height / Settings.Height;

                    if (
                        Snake[i].X < 0 || Snake[i].Y < 0 ||
                        Snake[i].X > maxXpos || Snake[i].Y > maxYpos
                        )
                    {
                        // end the game is snake either reaches edge of the canvas

                        die();
                    }

                    // detect collision with the body
                    // this loop will check if the snake had an collision with other body parts
                    //could this be optimized with a hashtable?
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            // if so we run the die function
                            die();
                        }
                    }

                    // detect collision between snake head and food
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        //if so we run the eat function
                        eat();
                    }

                }
                else
                {
                    // if there are no collisions then we continue moving the snake and its parts
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void generateFood()
        {

        }
        private void eat()
        {

        }
        private void die()
        {

        }

    }
}
