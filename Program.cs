using System;
using System.Collections.Generic;

namespace lambda
{
    class Program
    {
        public static List<int> ListOfNums = new List<int>{5,12,3};

        static List<int> MySelect(List<int> list, Func<int, int> f)
        {
            List<int> selectList = new List<int>();
            foreach (var number in list)
            {
                selectList.Add(f(number));
            }
            return selectList;
        }

        static List<int> MyWhere(List<int> list, Func<int, bool> f)
        {
            List<int> whereList = new List<int>();
            foreach (var number in list)
            {
                if (f(number))
                {
                    whereList.Add(number);
                }
            }
            return whereList;
        }

        static int MyAggregate(List<int> list, int seed, Func<int, int, int> f)
        {
            int aggregateNumber = seed;

            foreach (int num in list)
            {
                aggregateNumber = f(aggregateNumber,num);
            }

            return aggregateNumber;
        }

        static void Main(string[] args)
        {
            var selectTest = MySelect(ListOfNums, x => x + 1);
            var whereTest = MyWhere(ListOfNums, x => x % 2 == 0);
            var aggregateTest = MyAggregate(ListOfNums, 0, (sum, x) => sum + x);

            Console.WriteLine("Select: ");
            foreach (var num in selectTest)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Where: ");
            foreach (var num in whereTest)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Aggregate: ");
            Console.WriteLine(aggregateTest);
        }
    }
}
