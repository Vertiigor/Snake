using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Fundamentals
{
    public interface IMovable
    {
        public InputSystem.Direction direction { get; set; }
    }
}
