using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        // Variables and Collections
        Movement snakeMoves = new Movement();
        int lenght = 4, tick = 0;
        List<PictureBox> tails = new List<PictureBox>();
        List<Point> pastLocation = new List<Point>();
        Point far = new Point(1000, 1000);
        Apple apple = new Apple();
        int score = 0;
        MainMenu menu = new MainMenu();

        public Form1()
        {
            InitializeComponent();
        }

        // Timer to move snake with tail and check for collison
        private void HandleEvents_Tick(object sender, EventArgs e)
        {
            // apple render / tail create / head move
            appleBox.Location = apple.Location;
            snakeMoves.Move();
            head.Location = snakeMoves.HeadLocation;
            tailTimer.Start();
            // eating
            if (head.Location == apple.Location)
            {
                lenght++;
                RenderApple();
                score += 10;
            }
            // check for collision
            if (tick>lenght)
                Collision();
            // display score
            scoreLabel.Text = $"Score: {score}";
        }

        private void head_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        // Handle keys and send to move class
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
                 snakeMoves.HandleKeys(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Timer to set tail location and remove tail
        private void tailTimer_Tick(object sender, EventArgs e)
        {
            pastLocation.Add(head.Location);
            tails.Add(addTails());
            tails[tick].Location = pastLocation[tick];
            tails[tick].BringToFront();
            // removing
            if (tick > lenght-1)
                tails[tick - lenght].Location = far;
            tick++;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        // method to create new pictureBox of tail and set details
        private PictureBox addTails()
        {
            PictureBox tail = new PictureBox();
            tail.Name = "tail" + tick.ToString();
            tail.Size = new Size(28, 28);
            tail.Image = head.Image;
            
            this.Controls.Add(tail);
            return tail;
        }

        private void appleBox_Click(object sender, EventArgs e)
        {

        }

        // method to render apple location
        private void RenderApple()
        {
            bool isit = true;
            do
            {
                apple.RenderLocation();
                appleBox.Location=apple.Location;
                for (int i=1; i<lenght; ++i)
                {
                    if (apple.Location!=tails[tick-i].Location)
                        isit = false;
                }
            } while (isit == true);
        }

        // method to check collision
        private void Collision()
        {
            for (int i = 1; i < lenght; ++i)
                if (head.Location == tails[tick - i].Location)
                    Stop();

        }

        // method to exit game and display score
        private void Stop()
        {
            tailTimer.Stop();
            snakeTailTimer.Stop();
            MessageBox.Show($"Game Over!\nYour score: {score}!");
            this.Hide();
            menu.ShowDialog();
        }
    }
}
