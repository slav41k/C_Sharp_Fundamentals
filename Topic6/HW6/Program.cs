namespace HW6
{
    internal static class Program
    {
        static void Main()
        {
            Number.Input(out int lNum, out int rNum);
            Console.WriteLine($"Result of dividing: {Number.Div(lNum, rNum):N3}");

            List<int> nums = new();
            Number.ReadNumber(nums);
            Number.OutPut(nums);
        }
    }
}
