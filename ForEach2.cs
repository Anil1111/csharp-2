Using System;
public class ForEach2
{
   public static void Main()
   {
      // variables
      var names = new List<string>() { "John", "Tom", "Peter" };
      foreach (string name in names)
      {
        Console.WriteLine(name);
      }
  } // end of the program 
}
