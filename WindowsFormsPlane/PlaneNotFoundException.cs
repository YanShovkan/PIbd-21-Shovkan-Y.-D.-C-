using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{

    public class PlaneNotFoundException : Exception
    {
        public PlaneNotFoundException(int i) : base("Не найден самолёт по месту "
       + i)
        { }
    }

}
