using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace HW4p2
{
    class JPEGBuilder
    {
        public Image readImage(String path)
        {
            //Console.WriteLine(path);
            return Image.FromFile(path);
        }
    }
}
