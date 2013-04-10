using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HW4p1
{
    // Matthew Swenson
    // Archetecture
    // 3/10/2013
 
    class ColorBox : ICloneable
    {
        private int width {get ; set ;}
        public int Width{
            get{return width;}
            set { width = value; }
        }
        private int     height {get ; set ;}
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        private int depth { get; set; }
        public int Depth
        {
            get { return depth; }
            set { depth = value; }
        }

        private MyColor color { get; set; }
        public MyColor Color{
            get { return color; }
            set {color = value;}
        }
        private MyMaterial material { get; set; }
        public MyMaterial Material
        {
            get { return material; }
            set { material = value; }
        }
        public ColorBox(MyMaterial mat)
        {
            material = mat;
            width = 3;
            height = 4;
            depth = 5; 
            color = new MyColor(200, 100, 50);
        }
        public object Clone(){
            ColorBox newbox = (ColorBox) this.MemberwiseClone();

            return newbox;
        }

    }
}
