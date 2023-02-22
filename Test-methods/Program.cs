using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_methods
{
public static class Triangle
{
        //Anandita dutta 8881602
        public static void Main(string[] args) { }
    public static string ValidTriangle(int firstAngle, int secondAngle, int
    thirdAngle)
    {
        string result;
        if ((firstAngle + secondAngle + thirdAngle) == 90)
        {
            result = "The triangle is valid.";
        }
        else
        {
            result = "The triangle is NOT valid.";
        }
        return result;
    }
}
}
