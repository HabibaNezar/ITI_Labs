namespace q3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region range expression
            int[] arr = { 1, 2, 3, 4, 5, 6};
            int[] slice = arr[..2];
            Console.WriteLine(string.Join(",", slice));
            #endregion
        }
    }
}
