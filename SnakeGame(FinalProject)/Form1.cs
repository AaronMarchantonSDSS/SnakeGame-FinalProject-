//Aaron Marchanton
//May 27, 2024
//Snake Game

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SnakeGame_FinalProject_
{
    public partial class Form1 : Form
    {
        //set up for graphics
        Rectangle snake = new Rectangle(160, 300, 20, 20);
        Rectangle apple = new Rectangle(405, 305, 10, 10);

        SolidBrush snakeHeadBrush = new SolidBrush(Color.White);
        SolidBrush appleBrush = new SolidBrush(Color.Gold);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush purpleBrush = new SolidBrush(Color.Purple);
        SolidBrush pinkBrush = new SolidBrush(Color.HotPink);

        SoundPlayer eat = new SoundPlayer(Properties.Resources.eatSound);
        SoundPlayer lose = new SoundPlayer(Properties.Resources.loseSound);

        Random randValue = new Random();

        int snakeSpeed = 20;
        int snakeScore = 0;
        int applep1 = 0;
        int applep2 = 0;

        bool keepSpawning = false;

        string direction = "right";
        string colour = "none";

        List<Rectangle> bodyParts = new List<Rectangle>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //set home screen and display info
            if (gameTimer.Enabled == false)
            {
                if (redButton.Enabled == false)
                {
                    titleLabel.Text = "Snake Game!";
                    subtitleLabel.Text = "Press Space to Start or Esc to End";
                    colourLabel.Text = "";

                    if (snakeScore == 896)
                    {
                        scoreLabel.Text = $"You Win! Score: {snakeScore}";

                        imageLabel.Visible = true;
                        this.BackgroundImage = null;
                    }
                    else if (snakeScore != 0)
                    {
                        scoreLabel.Text = $"Previous Score: {snakeScore}";

                        imageLabel.Visible = true;
                        this.BackgroundImage = null;
                    }
                }
            }
            //set game screen and setup snake graphics
            else if (gameTimer.Enabled == true)
            {
                titleLabel.Text = "";
                subtitleLabel.Text = "";
                scoreLabel.Text = "";
                colourLabel.Text = "";

                imageLabel.Visible = false;

                e.Graphics.FillEllipse(snakeHeadBrush, snake);
                e.Graphics.FillEllipse(appleBrush, apple);

                for (int i = 0; i < bodyParts.Count(); i++)
                {
                    //Choosing snake body colour
                    if (colour == "Red")
                    {
                        e.Graphics.FillEllipse(redBrush, bodyParts[i]);
                    }
                    else if (colour == "Orange")
                    {
                        e.Graphics.FillEllipse(orangeBrush, bodyParts[i]);
                    }
                    else if (colour == "Yellow")
                    {
                        e.Graphics.FillEllipse(yellowBrush, bodyParts[i]);
                    }
                    else if (colour == "Green")
                    {
                        e.Graphics.FillEllipse(greenBrush, bodyParts[i]);
                    }
                    else if (colour == "Blue")
                    {
                        e.Graphics.FillEllipse(blueBrush, bodyParts[i]);
                    }
                    else if (colour == "Purple")
                    {
                        e.Graphics.FillEllipse(purpleBrush, bodyParts[i]);
                    }
                    else if (colour == "Pink")
                    {
                        e.Graphics.FillEllipse(pinkBrush, bodyParts[i]);
                    }
                }
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            PlayerMovement();
            CollisionWithWall();
            CollisionWithSelf();
            SnakeGetsApple();

            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //change direction upon press and make it move continuously
                case Keys.Up:
                    if (direction != "down")
                    {
                        direction = "up";
                    }
                    break;
                case Keys.Down:
                    if (direction != "up")
                    {
                        direction = "down";
                    }
                    break;
                case Keys.Left:
                    if (direction != "right")
                    {
                        direction = "left";
                    }
                    break;
                case Keys.Right:
                    if (direction != "left")
                    {
                        direction = "right";
                    }
                    break;
                //change screens or close program upon button press
                case Keys.Space:
                    if (gameTimer.Enabled == false)
                    {
                        ColourScreen();
                    }
                    break;
                case Keys.Escape:
                    if (gameTimer.Enabled == false)
                    {
                        Application.Exit();
                    }
                    break;
            }
        }

        public void PlayerMovement()
        {
            //move snake body parts to follow the other body parts
            for (int i = bodyParts.Count - 1; i > 0; i--)
            {
                bodyParts[i] = bodyParts[i - 1];
            }

            bodyParts[0] = snake;

            //controls snake movement
            if (direction == "up")
            {
                snake.Y = snake.Y - snakeSpeed;
            }
            if (direction == "down")
            {
                snake.Y = snake.Y + snakeSpeed;
            }
            if (direction == "left")
            {
                snake.X = snake.X - snakeSpeed;
            }
            if (direction == "right")
            {
                snake.X = snake.X + snakeSpeed;
            }
        }

        public void CollisionWithWall()
        {
            //check if snake hits the wall (game over)
            if (snake.Y > 580 || snake.Y < 0 || snake.X > 580 || snake.X < 0)
            {
                gameTimer.Enabled = false;

                lose.Play();
            }
        }

        public void CollisionWithSelf()
        {
            //check if snake hits itself (game over)
            for (int i = 0; i < bodyParts.Count(); i++)
            {
                if (bodyParts[i].IntersectsWith(snake))
                {
                    gameTimer.Enabled = false;

                    lose.Play();
                }
            }
        }

        public void SnakeGetsApple()
        {
            //if snake gets apple grow the body by 1
            if (snake.IntersectsWith(apple))
            {
                snakeScore++;

                eat.Play();

                bodyParts.Insert(bodyParts.Count, snake);

                keepSpawning = true;

                applep1 = randValue.Next(0, 30);
                applep2 = randValue.Next(0, 30);

                apple = new Rectangle(applep1 * 20 + 5, applep2 * 20 + 5, 10, 10);

                //Check apple won't spawn in snake
                while (keepSpawning == true)
                {
                    for (int i = 0; i < bodyParts.Count(); i++)
                    {
                        if (apple.IntersectsWith(bodyParts[i]))
                        {
                            applep1 = randValue.Next(0, 30);
                            applep2 = randValue.Next(0, 30);

                            apple = new Rectangle(applep1 * 20 + 5, applep2 * 20 + 5, 10, 10);

                            keepSpawning = true;

                            break;
                        }
                        keepSpawning = false;
                    }
                }
            }
        }

        public void InitializeGame()
        {
            //set up the game screen and draw graphics
            gameTimer.Enabled = true;

            snakeScore = 0;

            direction = "right";

            snake = new Rectangle(160, 300, 20, 20);
            apple = new Rectangle(405, 305, 10, 10);

            bodyParts.Clear();
            bodyParts.Add(new Rectangle(140, 300, 20, 20));
            bodyParts.Add(new Rectangle(120, 300, 20, 20));
            bodyParts.Add(new Rectangle(100, 300, 20, 20));

            redButton.Visible = false;
            orangeButton.Visible = false;
            yellowButton.Visible = false;
            greenButton.Visible = false;
            blueButton.Visible = false;
            purpleButton.Visible = false;
            pinkButton.Visible = false;

            redButton.Enabled = false;
            orangeButton.Enabled = false;
            yellowButton.Enabled = false;
            greenButton.Enabled = false;
            blueButton.Enabled = false;
            purpleButton.Enabled = false;
            pinkButton.Enabled = false;

            this.BackgroundImage = Properties.Resources.gridImage;
        }

        public void ColourScreen()
        {
            titleLabel.Text = "";
            subtitleLabel.Text = "";
            scoreLabel.Text = "";
            colourLabel.Text = "Select a Colour to Start";

            redButton.Visible = true;
            orangeButton.Visible = true;
            yellowButton.Visible = true;
            greenButton.Visible = true;
            blueButton.Visible = true;
            purpleButton.Visible = true;
            pinkButton.Visible = true;

            redButton.Enabled = true;
            orangeButton.Enabled = true;
            yellowButton.Enabled = true;
            greenButton.Enabled = true;
            blueButton.Enabled = true;
            purpleButton.Enabled = true;
            pinkButton.Enabled = true;

            Refresh();
        }

        //Setup game with chosen colour snake (colour = button pressed)
        private void redButton_Click(object sender, EventArgs e)
        {
            InitializeGame();

            gameTimer.Enabled = true;

            colour = "Red";
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            InitializeGame();

            gameTimer.Enabled = true;

            colour = "Orange";
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            InitializeGame();

            gameTimer.Enabled = true;

            colour = "Yellow";
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            InitializeGame();

            gameTimer.Enabled = true;

            colour = "Green";
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            InitializeGame();

            gameTimer.Enabled = true;

            colour = "Blue";
        }

        private void purpleButton_Click(object sender, EventArgs e)
        {
            InitializeGame();

            gameTimer.Enabled = true;

            colour = "Purple";
        }

        private void pinkButton_Click(object sender, EventArgs e)
        {
            InitializeGame();

            gameTimer.Enabled = true;

            colour = "Pink";
        }
    }
}