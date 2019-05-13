namespace TestNinJa.Fundamentals
{
    public class FizzBuzz
    {
        public static string GetOutput(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
                return "Fizz Buzz";
            if (number % 3 == 0)
                return "Fizz";
            if (number % 5 == 0)
                return "Buzz";
            return number.ToString();
        }
    }
}
