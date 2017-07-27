using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {
       public double latura;
        public float arie;


        public override float Area(float latura)
        {
            arie = latura * latura;
            return arie;
        }

        public override double Latura(double arie)
        {
            latura = Math.Sqrt(arie);
            return latura;
        }
    }
}
