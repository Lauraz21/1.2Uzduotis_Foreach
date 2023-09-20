namespace _1._2Uzduotis_Foreach
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { -1, -2, 1, 2 };
            int[] result = GetPositiveNumbers(numbers);
        
            foreach (int number in result)
            {
            Console.WriteLine(number);
            }
        }
        public static int[] GetPositiveNumbers(int[] numbers)
        {
            int[] newArray = new int[numbers.Length];

            int i = 0; 
            foreach (int item in numbers)
            {

                if (item > 0)
                {
                    newArray[i] = item;
                    i++;
                }
                
            }
            return newArray;


        }
    }
}