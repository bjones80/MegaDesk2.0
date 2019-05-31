using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskProject_1
{
    public enum DesktopMaterial
    {
        laminate,
        oak,
        rosewood,
        veneer,
        pine
    }



    public class Desk
    {
        public int width { get; set; }
        public int depth { get; set; }
        public int numDrawers { get; set; }
        public DesktopMaterial surfaceMaterial { get; set; }


        // Non-Default Constructor 
        //public Desk(int pvWidth, int pvDepth, int pvDrawers, int pvMaterial)
        //{
        //    this.width = pvWidth;
        //    this.depth = pvDepth;
        //    this.numDrawers = pvDrawers;
        //    this.surfaceMaterial = pvMaterial;
        //}
        
           
        public decimal surfaceArea()
        {
            return width * depth;
        }

    }
}
