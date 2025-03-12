namespace OnsdagKodtest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(MestFrekventSiffra(new int[] { 1, 3, 2, 3, 4, 1, 3, 2, 2, 2, 5 }));
            Console.WriteLine(MestFrekventSiffra(new int[] { 7, 7, 5, 5, 1, 1, 1, 2, 2, 2 }));

        }

        public static int MestFrekventSiffra(int[] arr)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (var item in arr )
            {

                if (counts.ContainsKey(item))
                {

                    counts[item]++;
                }
                else
                {
                    counts[item] = 1;
                }

            }
            int maxCount = counts.Values.Max();
            return counts.First(x => x.Value == maxCount).Key;
            
        }



    }
}



 

