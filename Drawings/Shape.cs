using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawings
{
    public abstract class Shape
    {
        protected float XOrigin { get; set; }
        protected float YOrigin { get; set; }

        public Shape(float xOrigin, float yOrigin)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
        }

        public abstract void Draw();

        public void MoveTo(float x, float y)
        {
            XOrigin = x;
            YOrigin = y;
        }

        protected void ResetTurtle()
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 0;  //Always start from North
            Turtle.X = XOrigin;
            Turtle.Y = YOrigin;
        }

    }
}
