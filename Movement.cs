﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Movement
    {
        // Starting position
        public Point HeadLocation = new Point(266, 266);
        // Default direction
        private char direction = 'l';

        // Change keys to direction
        public void HandleKeys(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && direction != 'u') 
            {
                direction = 'd';
            }
            if (e.KeyCode == Keys.Up && direction != 'd')
            {
                direction = 'u';
            }
            if (e.KeyCode == Keys.Left && direction != 'r')
            {
                direction = 'l';
            }
            if (e.KeyCode == Keys.Right && direction != 'l')
            {
                direction = 'r';
            }
        }

        // Methon to run snake head
        public void Move()
        {
            switch (direction)
            {
                case 'd':
                    HeadLocation.Y += 28;
                    break;
                case 'u':
                    HeadLocation.Y -= 28;
                    break;
                case 'l':
                    HeadLocation.X -= 28;
                    break;
                case 'r':
                    HeadLocation.X += 28;
                    break;

            }
            BorderCrossing();
        }

        // Check if head crossing the border
        // and move it to oder border
        private void BorderCrossing()
        {
            // X-axis
            switch (HeadLocation.X)
            {
                case -14:
                    HeadLocation.X = 462;
                    break;
                case 490:
                    HeadLocation.X = 14;
                    break;
            }

             // Y-axis
            switch (HeadLocation.Y)
            {
                case -14:
                    HeadLocation.Y = 462;
                    break;
                case 490:
                    HeadLocation.Y = 14;
                    break;
            }
        }
      
    }
}
