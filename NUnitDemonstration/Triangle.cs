using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemonstration
{
    public class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
        {
            int sumOfAngles = firstAngle + secondAngle + thirdAngle;
            if (sumOfAngles != 180)
            {
                return "Not a valid triangle";
            }

            if (firstAngle <= 0 || secondAngle <= 0 || thirdAngle <= 0)
            {
                return "Angles should be greater than 0";
            }

            return "Valid triangle";
        }

    }
}
