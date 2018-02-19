using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawings
{
    public class EquilateralTriangle
    {
        //Properties
        public float XOrigin { get; private set; }
        public float YOrigin { get; private set; }
        public float SideLength { get; private set; }

        //The 'Constructor'
        public EquilateralTriangle(float xOrigin, float yOrigin, float sideLength)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
            SideLength = sideLength;
        }
    }
}
