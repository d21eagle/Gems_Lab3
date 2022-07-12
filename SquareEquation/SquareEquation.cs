
namespace Apr6_SquareEquation
{
    public class SquareEquation
    {
        public static double[] SolveSquareEquation(double a, double b, double c)
        {
            double D;
            D = b * b - 4 * a * c;
        
            if (D > 0) 
            {
                if (a == 0)
                {
                    double[] root = new double[1];
                    root[0] = (-c) / b;
                    return root;
                }

                else 
                {
                    double[] root = new double[2];
                    root[0] = (-b - Math.Sqrt(D)) / (2 * a);
                    root[1] = (-b + Math.Sqrt(D)) / (2 * a);
                    return root;
                }
            }
        
            if (D == 0) 
            {
                double[] root = new double[1];
                root[0] = (-b) / (2 * a);
                return root;
            }
        
            else throw new ArgumentException("Нет корней!");
        }
    }
}

