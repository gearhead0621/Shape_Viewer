using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeUI.ShapeModel
{
    interface IShape {

        System.Drawing.Color Color     { get; set;}
        double               Perimeter { get; }
        double               CalculateArea();
        void                 Draw(Graphics g);
        

    }

}
