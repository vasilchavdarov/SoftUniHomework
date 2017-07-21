﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        

        public Box(double lenght, double width, double height)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = height;
        }

        private double Length
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative. ");
                }
                this.length = value;
            }
        }

        private double Width
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative. ");
                }
                this.width = value;
            }
        }

        private double Height
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative. ");
                }
                this.height = value;
            }
        }


        public double GetSurfaceArea()
        {
            return (2 * this.length * this.width) + (2 * this.length * this.height) + (2 * this.width * this.height);
        }

        public double GetLateralSurfaceArea()
        {
            return (2 * this.length * this.height) + (2 * this.width * this.height);
        }

        public double GetVolume()
        {
            return this.length * this.width * this.height;
        }
    }
}
