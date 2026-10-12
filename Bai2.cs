internal class Ex2_The_Two_diff_biggest_value
{
    
    
    private static void Main2(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int n = int.Parse(Console.ReadLine() ?? "5");
        int [] arr = new int[n];

        for (int i = 0 ; i < n ; i++)
        {
            System.Console.WriteLine($"Enter the {i} value of the array: ");
            arr[i] = int.Parse(Console.ReadLine() ?? "1");
        }
        int max1 = int.MinValue;
        int max2 = int.MinValue;

        for (int i = 0 ; i < n; i++)
        {
            if(arr[i] > max1)
            {
                max2 = max1;
                max1 = arr[i];
            }
            else if ( arr[i] < max1 && arr[i] > max2 )
            {
                max2 = arr[i];
            }
        }
        if (max2 == int.MinValue)
        {
            System.Console.WriteLine("NO");
        }
        
        else System.Console.WriteLine($"{max1} {max2}");
    }
}