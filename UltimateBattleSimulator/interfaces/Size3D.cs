using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.interfaces
{
    public struct Size3D
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }

        public Size3D(double width, double height, double depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
        }

        public override string ToString()
        {
            return $"Width: {Width}, Height: {Height}, Depth: {Depth}";
        }
    }

}
