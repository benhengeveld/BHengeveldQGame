using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHengeveldQGame
{
    /// <summary>
    /// Layout for a two point position
    /// </summary>
    public class Vector2
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
