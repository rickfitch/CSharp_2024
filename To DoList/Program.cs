
Console.WriteLine("Hello, World!");

int sum = Sum(10, 21, 13, 45, 56, 75, -30,45,67);
Console.WriteLine(sum.ToString());




  static int Sum(params int[] numbers)
{
    int sum = 0;
    foreach(int number in numbers) 
    { 
        sum += number; 
    }
    return sum;

}