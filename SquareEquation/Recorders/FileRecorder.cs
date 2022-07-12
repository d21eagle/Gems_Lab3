using System.IO;
using Apr6_SquareEquation.Interfaces;

namespace Apr6_SquareEquation.Recorders
{
    public class FileRecorder : IRecorder
    {
        private readonly string _inputFileName;

        public FileRecorder(string inputFileName)
        {
            _inputFileName = inputFileName;
        }

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
            Console.Write("\n");
            
            StreamReader sr = new StreamReader(_inputFileName);
            if (File.Exists(_inputFileName))
            {
                string text = sr.ReadToEnd();
                sr.Close();

                string[] contain = text.Split(' ');

                for (int i = 0; i < eqCount * 3; i++)
                {
                    coeffs[i] = Double.Parse(contain[i]);
                }
            }
            else throw new FileNotFoundException();
            
            return coeffs;
        }
    }
}

