using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class AirfieldgAlreadyHaveThisPlaneException : Exception
    {
        public AirfieldgAlreadyHaveThisPlaneException() : base("На аэродроме уже есть такой " +
            "самолёт")
        { }
    }
}
