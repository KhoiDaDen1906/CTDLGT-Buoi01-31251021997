internal class Ex1_IO_AND_Condition_solving
{
    static int Max_3_Num(int a , int b , int c)
    {
        int max = a;
        if (b > max ) max = b;
        if (c > max) max = c;
        return max;
    }
    static int Min_3_Num(int a , int b , int c)
    {
        int min = a ; 
        if (b < min ) min = b;
        if (c < min) min = c;
        return min;
    }
    static int Sum_of_3Num(int a, int b , int c)
    {
        int sum = a + b + c;
        return sum;
    }
    static void Bai_1()
    {
        System.Console.WriteLine("Enter first integer num: ");
        int num1 = int.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Enter second integer num: ");
        int num2 = int.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Enter third integer num: ");
        int num3 = int.Parse(Console.ReadLine() ?? "1");

        int lon_nhat = Max_3_Num(num1, num2, num3);
        int be_nhat = Min_3_Num(num1, num2, num3);
        int tong = Sum_of_3Num(num1, num2, num3);
        double trung_binh = tong/3.0;

        System.Console.WriteLine($"Lớn nhất: {lon_nhat}; nhỏ nhất: {be_nhat} ; tổng: {tong} ; trung bình: {trung_binh:F2}");

    }
    private static void Main1(string[] args)
    {
        Bai_1();
    }
}
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