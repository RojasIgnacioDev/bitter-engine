using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitterEngine.Source
{
    public class Shape2D
    {
        public Vector2 Position { get; set; } = null;
        public Vector2 Scale { get; set; } = null;

        public Shape2D(Vector2 position, Vector2 scale) {
            Position = position;
            Scale = scale;
        }
    }
}
