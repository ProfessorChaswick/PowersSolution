public class Program
{
    public static int PowerRanger(int power, int min, int max)
    {
        int numOfPows = 0;
        double Pows = (double)power;
        Pows = 1d / Pows;
        for(int x = min; x <= max; x++)
        {
            if(Math.Ceiling(Math.Pow(x, Pows)) ==
                Math.Floor(Math.Pow(x, Pows)))
                numOfPows++;
        }
        return numOfPows;
    }
    public static void Main()
    {
        Console.WriteLine("The answer is {0}", PowerRanger(2,1,100));
    }
}