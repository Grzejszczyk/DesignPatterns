using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle : Shape, IPrototype
    {
        private int _radius;
        private Circle() { }

        public Circle(Shape shape, int radius)
        {
            _centerPoint = new(shape.GetCenterPoint(shape).Item1, shape.GetCenterPoint(shape).Item2);
            _radius = radius;
        }
        public override IPrototype Clone()
        {
            var p = new Circle();
            p._centerPoint = new(this.GetCenterPoint(this).Item1, this.GetCenterPoint(this).Item2);
            p._radius = this._radius;

            return p;
        }

        public override Tuple<int, int> GetCenterPoint(IPrototype prototype)
        {
            return _centerPoint;
        }
    }
}
