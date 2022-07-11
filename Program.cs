using System;
namespace ConsoleApp35
{
    class Program
    {
        public static void Main()
        {
            Repeater repeater = new(4, "Irada");
            repeater.ReturnWordRepeatedNumberTimes();
        }
      
    }
   class Repeater
    {
        public int NumberOfString { get; set; }
        public string String { get; set; }
        public Repeater(int numberOfString, string s)
        {
            this.NumberOfString = numberOfString;
            this.String = s;
        }
        public void ReturnWordRepeatedNumberTimes()
        {
            for (int i = 1; i <= NumberOfString; i++)
            {
                Console.Write(String);
            }
            
        }
    }
}