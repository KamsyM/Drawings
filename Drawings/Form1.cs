using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;
using System.Collections;

namespace Drawings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Shape> shapes = new List<Shape>();

        private Shape mostRecent;

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //Transform windows coordinates to Turtle coordinates
            float turtleX = e.X - Width / 2 + 8;
            float turtleY = Height / 2 - e.Y - 19;
            string selectedItem = (string)comboBox1.SelectedItem;
            if (selectedItem == "Draw Triangle") //We will add more options later
            {
                var trg = new EquilateralTriangle(turtleX, turtleY, 50);
                shapes.Add(trg);
                mostRecent = trg;
            }

            if (selectedItem == "Draw Rectangle")
            {
                var rec = new Rectangle(turtleX, turtleY, 100, 50);
                shapes.Add(rec);
                mostRecent = rec;
            }
            if (selectedItem == "Move Shape")
            {
                mostRecent.MoveTo(turtleX, turtleY);
            }
            Turtle.Dispose();
            DrawAll();
        }

        public void DrawAll()
        {
            Turtle.Dispose();
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }


    }
}
