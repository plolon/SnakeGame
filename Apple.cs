using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Apple
    {
        // Variables and private property
        private Random rand = new Random();
        private Point location = new Point(42, 42);
        public Point Location { get =>location; set=>RenderLocation(); }

        // Render pixels for apple location
        public void RenderLocation()
        {
            location.X = 28 * (rand.Next(1, 17)) - 14;
            location.Y = 28 * (rand.Next(1, 17)) - 14;
        }
    }
}
