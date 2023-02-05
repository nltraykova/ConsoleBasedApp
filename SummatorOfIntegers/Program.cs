namespace SummatorOfIntegers
{
    public class Program
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Console.WriteLine("The sum is: ");
            Console.WriteLine(nums.Sum());
        }
    }
}