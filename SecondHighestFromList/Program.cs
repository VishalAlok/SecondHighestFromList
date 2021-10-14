using System;
using System.Collections.Generic;

namespace SecondHighestFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> MyList = new List<int>() { 12,23,54};
            MyList.Add(11); MyList.Add(11);
            MyList.Add(5); MyList.Add(2);
            MyList.Add(4); MyList.Add(6);

            int largest = int.MinValue;
            int second = int.MinValue;

            foreach (int i in MyList)
            {
                if (i > largest)
                {
                    second = largest;
                    largest = i;
                }
                else if (i > second)
                    second = i;
            }

            Console.WriteLine(second);
        }
    }
}
