using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HW4p2
{
    class TextBuilder
    {
        public String getText(String path)
        {
            string text = System.IO.File.ReadAllText(path);
            return text;
        }
    }
}
