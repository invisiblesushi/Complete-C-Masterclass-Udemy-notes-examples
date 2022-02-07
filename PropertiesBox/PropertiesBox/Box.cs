using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesBox
{
    class Box
    {
        //Member variable
        private string color = "white";
        private int length;
        private int height;
        private int volume;

        //Property
        public int Width { get; set; }

        //Constructor
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.Width = width;
        }


        public int FrontSurface
        {
            get
            {
                return height * length;
            }


        }
    }
}
