using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Rectangle : IDrawable
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    public int Height
    {
        get { return this.height; }
        private set { this.height = value; }
    }


    public int Width
    {
        get { return this.width; }
        private set { this.width = value; }
    }

    public void Draw()
    {
    }
}
