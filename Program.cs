using System;
public delegate int NumberChanger(int N);
namespace DelegateExample
{
    public  class Program
    {
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MULNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}",GetNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}",GetNum());
            Console.ReadKey();
        }
        static int num = 10;
        public static int AddNum(int p)
        {
            return num += p;
        }
        public static int MULNum(int p)
        {
            return num *= p;
        }
        public static int GetNum()
        {
            return num;
        }

    }
    

}
