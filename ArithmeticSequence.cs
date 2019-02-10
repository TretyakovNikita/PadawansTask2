using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException();
            }
            if (number == int.MaxValue || number == int.MinValue)
            {
                throw new OverflowException();
            }
            int temp = 0;
            for (int i = 0; i < count; i++)
            {
                temp = temp + number + add * i;
            }
            
            return temp;
            


        }
    }
}
