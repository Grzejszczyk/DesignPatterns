using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Shape : IPrototype
    {
        protected Tuple<int, int> _centerPoint;
        public Shape() { }
        public Shape(int x, int y)
        {
            _centerPoint = new(x, y);
        }
        //public Shape(Shape shape)
        //{
        //    _centerPoint = new(shape._centerPoint.Item1, shape._centerPoint.Item2);
        //}
        public virtual IPrototype Clone()
        {
            var p = new Shape();
            p._centerPoint = new(this._centerPoint.Item1, this._centerPoint.Item2);

            return p;
        }

        public virtual Tuple<int, int> GetCenterPoint(IPrototype prototype)
        {
            return _centerPoint;
        }

        public virtual void ResetCP()
        {
            _centerPoint = new(0, 0);
        }
    }
}
