using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.SOLIDPrinciples.OpenClosed
{
    public enum ShapeType
    {
        [Description("Circle")]
        Circle = 1,
        [Description("Rectangle")]
        Rectangle = 2,
    }
}
