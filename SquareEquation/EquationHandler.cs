
using Apr6_SquareEquation.Interfaces;

namespace Apr6_SquareEquation
{
    public class EquationHandler
    {
        private static IRecorder _recorder = null!;

        public EquationHandler(IRecorder recorder)
        {
            _recorder = recorder;
        }
        public void Handle()
        {
            double[] coeffs = _recorder.Record();

            if (coeffs.Equals(null))
                throw new ArgumentException("Отсутствует описание уравнений!");

            int counter = 3;
            var eqs = coeffs.GroupBy(_ => counter++ / 3).Select(v => v.ToArray());
                    
            Console.Write("Корни уравнения:\n");
            foreach (var array in eqs)
            {
                double a = array[0];
                double b = array[1];
                double c = array[2];
                try 
                {
                    double[] res = SquareEquation.SolveSquareEquation(a, b, c);
                    foreach (var t in res)
                    {
                        Console.Write("{0:0.00}", t);
                        Console.Write(" ");
                    }
                    Console.Write("\n");
                } 
                catch (ArgumentException) 
                {
                    Console.WriteLine("Нет корней!");
                }
            }
        }
    }
}

