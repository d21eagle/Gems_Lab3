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
           
            if (new FileInfo(_inputFileName).Length == 0 || !File.Exists(_inputFileName)) {
                throw new FileNotFoundException("Файл пуст или не найден!");
            } 
            
            // Количество уравнений в первой строке файла
            eqCount = Convert.ToInt32(File.ReadLines(_inputFileName).First());
            if (eqCount <= 0)
                throw new ArgumentException("Не указано количество уравнений!");
            
            coeffs = new double[eqCount * 3];
            Console.Write("\n");
            
            StreamReader sr = new StreamReader(_inputFileName);
            sr.ReadLine();
            string text = sr.ReadToEnd();
            sr.Close();

            string[] contain = text.Split(new char[] {' ', '\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < eqCount * 3; i++)
                coeffs[i] = Double.Parse(contain[i]);

            return coeffs;
        }
    }
}

