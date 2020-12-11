using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class PlaneComparer : IComparer<AirPlane>

    {
        public int Compare(AirPlane x, AirPlane y)
        {
            if(x is SeaPlane && y is SeaPlane)
            {
                return ComparerSeaPlane((SeaPlane)x, (SeaPlane)y);
            }
            if(x is SeaPlane && y is Plane)
            {
                return -1;
            }
            if (x is Plane && y is SeaPlane)
            {
                return 1;
            }
            if (x is Plane && y is Plane)
            {
                return ComparerPlane((Plane)x, (Plane)y);
            }
            return 0;
        }
        private int ComparerPlane(Plane x, Plane y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerSeaPlane(SeaPlane x, SeaPlane y)
        {
            var res = ComparerPlane(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.LowerWing != y.LowerWing)
            {
                return x.LowerWing.CompareTo(y.LowerWing);
            }
            if (x.PlaneFloat != y.PlaneFloat)
            {
                return x.PlaneFloat.CompareTo(y.PlaneFloat);
            }
            return 0;
        }
    }
}
