using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskProject_1
{
    class Desk
    {


        private int width;
        private int depth;
        private int numberOfDrawers;
        private String surfaceMaterial;

        public
            enum DesktopMaterial
        {
            laminate = 0,
            oak = 1,
            rosewood = 2,
            veneer = 3,
            pine = 4
        }

        public float surfaceArea()
        {
            return width * depth;
        }

    }
}
