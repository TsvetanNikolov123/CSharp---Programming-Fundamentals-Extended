namespace _04.Nth_Digit
{
    using System;

    public class NthDigit
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());             // Пример: 83546  като индекса започва да се брои от дясно на лаво по числото...
            int index = int.Parse(Console.ReadLine());                // Пример: 4  ... в примера числото 83546 с индекс 4 => отговора е 3
            Console.WriteLine(FindNthDigit(number, index));           //
        }                                                             //
                                                                      //
        public static long FindNthDigit(long number, int index)       //
        {                                                             //
            int currentIndex = 1;             // 
            while (number != 0)               //    Ползваме While Loop ... докато number ни е ралично от нула защото в тялото на loop-а от числото което са ни подали
            {                                 //    ще махаме последната цифра за да стигнеме до до индекса на числото което търсиме
                if (currentIndex == index)    //    За да разбереме кога да спреме с махането на последната цифра от числото си правиме един currentIndex който увеличаваме
                {                             //    със всяка итерация на Loop-а докато не стане равен на индекса който са ни подали.
                    return number % 10;       //
                }                             //
                currentIndex++;               //
                number /= 10;                 //
            }                                 //
            return number % 10;               //       Тук се застраховаме че ако ни подадат 0 като число няма да върнеме индекс 1.
        }
    }
}
