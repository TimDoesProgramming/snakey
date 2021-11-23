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
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>(); // creating an list array for the snake
        private Circle food = new Circle(); // creating a single Circle class called food
        public Form1()
        {
            InitializeComponent();

            new Settings(); // linking the Settings Class to this Form

            gameTimer.Interval = 1000 / Settings.Speed; // Changing the game time to settings speed
            gameTimer.Tick += updateScreen; // linking an updateScreen function to the timer
            gameTimer.Start(); // starting the timer

            startGame(); // running the start game function
        }
        private void updateSreen(object sender, EventArgs e)
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
