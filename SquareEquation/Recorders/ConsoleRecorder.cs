using Apr6_SquareEquation.Interfaces;

namespace Apr6_SquareEquation.Recorders
{
    public class ConsoleRecorder : IRecorder
    {
        public double[] Record()
        {
            int eqCount = 0;
            double[] coeffs;

            do
            {
                Console.Write("Введите количество уравнений:\n");
                eqCount = Convert.ToInt32(Console.ReadLine());
            } while (eqCount <= 0);
            
            coeffs = new double[eqCount * 3];
            Console.Write("Введите, пожалуйста, коэффициенты:\n");
            for (int i = 0; i < eqCount * 3; i++)
                coeffs[i] = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");

            return coeffs;
        }
    }
}

