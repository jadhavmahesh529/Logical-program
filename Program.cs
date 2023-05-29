namespace Logicalprogramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Fibonacciseries series = new Fibonacciseries();
          series.GenerateFibonacciSeries();


            Perfectnumber perfectnumber = new Perfectnumber();
            perfectnumber.GeneratePerfectNumber();

            Primenumber primenumber = new Primenumber();    
            primenumber.GeneratePrimeNumber();

            Reversenumber reversenumber = new Reversenumber();  
            reversenumber.GenerateReverseNumber();
        }
    }
}