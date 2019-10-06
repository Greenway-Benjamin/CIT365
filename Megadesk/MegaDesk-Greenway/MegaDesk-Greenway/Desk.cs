using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Greenway
{
    public class Desk
    {
        int depth, width, drawers;
        string surfaceMaterial;



        public Desk(int depth, int width, int drawers, string surfaceMaterial)
        {
            this.Depth = depth;
            this.Width = width;
            this.Drawers = drawers;
            this.SurfaceMaterial = surfaceMaterial;
        }

        public int getSurfaceArea()
        {
            return this.depth * this.width;
        }

        public int Depth { get => depth; set => depth = value; }
        public int Drawers { get => drawers; set => drawers = value; }
        public int Width { get => width; set => width = value; }
        public string SurfaceMaterial { get => surfaceMaterial; set => surfaceMaterial = value; }
    }
    enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}
