using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.interfaces
{
    public class Size3D
    {
        private int _minimalTotal = 0;

        private int _width = 0;
        public int Width 
        {
            get 
            {
                return _width;
            } 
            set 
            {
                if( !IsUndresize(value, Height, Tall) ) 
                {
                    _width = value;
                }
            } 
        }

        private int _height = 0;
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (!IsUndresize(Width, value, Tall))
                {
                    _height = value;
                }
            }
        }

        private int _tall = 0;
        public int Tall
        {
            get
            {
                return _tall;
            }
            set
            {
                if (!IsUndresize(Width, Height, value))
                {
                    _tall = value;
                }
            }
        }

        public int Total { 
            get 
            {
                return Width * Height * Tall;
            } 
        }

        public Size3D(int minimalSize = 0) 
        {
            _minimalTotal = minimalSize;
        }

        public Size3D(Size3D size, int minimalSize = 0) : this(minimalSize)
        {
            _width = size.Width;
            _height = size.Height;
            _tall = size.Tall;
        }

        public Size3D(int width, int height, int Tall, int minimalSize = 0) : this(minimalSize)
        {
            _width = width;
            _height = height;
            _tall = Tall;
        }

        private bool IsUndresize(int width, int height, int tall) 
        {
            int total = width * height * tall;
            
            return total < _minimalTotal;
        }

        public override string ToString()
        {
            return $"Width: {Width}, Height: {Height}, Tall: {Tall}";
        }
    }

}
