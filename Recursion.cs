using System;
class program
{
    public static void Main()
{
        // intialize variables 
    int num, result;
    pro pg = new pro();
    Console.WriteLine("Enter the Number : ");
    num=int.Parse(Console.ReadLine());
        // result 
    result =pg.sum(num);
        // print
    Console.WriteLine("Sum of Digits in {0} is {1}", num, result);
    Console.ReadLine();
}
}
class pro
{
    public int sum(int num)
    {
        if (num != 0)
        {
            // iterate 
            return (num % 10 + sum(num / 10));
        }
        else
        {
            //whenndone tetuen 0
            return 0;
        }
    }// end of the program
}
