namespace SortedArray
{
    public class Program
    {
        public static int[] mergearray(int[] arr1,int[] arr2)   //creating method to merge 2 arrays
        {
            int[] arrconcat = arr1.Concat(arr2).ToArray();   //concating 2 arrays
            Array.Sort(arrconcat);                      //sorting concatenated array

            return arrconcat;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of the array:");
            int size = int.Parse(Console.ReadLine());
             int[] arr1 = new int[size];

            Console.WriteLine("enter the 1st array elements:");      //printing 1st array elements
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("enter the size2 of the array:");
            int size2 = int.Parse(Console.ReadLine());
            int [] arr2 = new int[size2];
            Console.WriteLine("enter the 2nd array elements:");
            for (int i = 0; i < arr2.Length; i++)                  //printing 2nd array elements
            {
                arr2[i] = int.Parse(Console.ReadLine());   
            }
            int[] mergearraysort = mergearray(arr1,arr2);

            Console.WriteLine("merged sorted array is:");           //printing merged array elements
            foreach (int i in mergearraysort)
            {
                Console.WriteLine( i);
            }
        }
    }
}
