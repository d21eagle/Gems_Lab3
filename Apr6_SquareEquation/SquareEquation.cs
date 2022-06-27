namespace Apr6_SquareEquation;

public class SquareEquation
{
    private double a, b, c;
    
    public SquareEquation(double a, double b, double c) 
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double[] SolveSquareEquation()
    {
        double D;
        double[] root = new double[2];
        D = b * b - 4 * a * c;
        
        if (D > 0) 
        {
            if (a == 0) root[0] = (-c) / b;
            
            else 
            {
                root[0] = (-b - Math.Sqrt(D)) / (2 * a);
                root[1] = (-b + Math.Sqrt(D)) / (2 * a);
            }
            return root;
        }
        
        if (D == 0) 
        {
            root[0] = (-b) / (2 * a);
            return root;
        }
        
        else throw new ArgumentException("Нет корней!");
    }
}