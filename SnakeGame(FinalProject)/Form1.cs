﻿//Aaron Marchanton
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
    public partial class greenButton : Form
    {
        //set up locations for graphics
        Rectangle snake = new Rectangle(160, 300, 20, 20);
        Rectangle apple = new Rectangle(405, 305, 10, 10);

        SolidBrush redBrush = new SolidBrush(Color.DarkRed);
        SolidBrush blueBrush = new SolidBrush(Color.CornflowerBlue);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush greenBrush = new SolidBrush(Color.Green);

        SoundPlayer eat = new SoundPlayer(Properties.Resources.eatSound);
        SoundPlayer lose = new SoundPlayer(Properties.Resources.loseSound);

        Random randValue = new Random();

        int snakeSpeed = 20;
        int snakeScore = 0;
        int applep1 = 0;
        int applep2 = 0;

        bool keepSpawning = false;

        string direction = "right";
        string colour = "Orange";

        List<Rectangle> bodyParts = new List<Rectangle>();

        public greenButton()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //set launch screen 
            if (gameTimer.Enabled == false && snakeScore == 0)
            {
                titleLabel.Text = "Snake Game!";
                subtitleLabel.Text = "Press Space to Start or Esc to End";
            }
            //set game screen and setup snake graphics
            else if (gameTimer.Enabled == true)
            {
                imageLabel.Visible = false;

                e.Graphics.FillEllipse(redBrush, snake);
                e.Graphics.FillEllipse(blueBrush, apple);

                for (int i = 0; i < bodyParts.Count(); i++)
                {
                        e.Graphics.FillEllipse(orangeBrush, bodyParts[i]);
                }
            }
            //set game over screen
            else if (gameTimer.Enabled == false)
            {
                titleLabel.Text = "Snake Game!";
                subtitleLabel.Text = "Press Space to Start or Esc to End";
                scoreLabel.Text = $"Previous Score: {snakeScore}";

                imageLabel.Visible = true;
                this.BackgroundImage = null;
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
                        InitializeGame();
                        gameTimer.Enabled = true;
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
            titleLabel.Text = "";
            subtitleLabel.Text = "";
            scoreLabel.Text = "";

            gameTimer.Enabled = true;

            snakeScore = 0;

            direction = "right";

            snake = new Rectangle(160, 300, 20, 20);
            apple = new Rectangle(405, 305, 10, 10);

            bodyParts.Clear();
            bodyParts.Add(new Rectangle(140, 300, 20, 20));
            bodyParts.Add(new Rectangle(120, 300, 20, 20));
            bodyParts.Add(new Rectangle(100, 300, 20, 20));

            this.BackgroundImage = Properties.Resources.gridImage;
        }
    }
}