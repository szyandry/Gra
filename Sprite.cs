using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    class Sprite
    {
        public Bitmap CurrentSprite;
        public bool Show;
        public int _x, _y, _width, _height;
        public Sprite(string filename, int x , int y)
        {
            CurrentSprite = new Bitmap(filename);
            _x = x;
            _y = y;
            _width = CurrentSprite.Width;
            _height = CurrentSprite.Height;
            Show = true;
        }
        public Sprite(string filename, int x, int y, int w , int h)
        {
            CurrentSprite = new Bitmap(filename);
            _x = x;
            _y = y;
            _height = h;
            _width = w;
            Show = true;
        }
    }
}
