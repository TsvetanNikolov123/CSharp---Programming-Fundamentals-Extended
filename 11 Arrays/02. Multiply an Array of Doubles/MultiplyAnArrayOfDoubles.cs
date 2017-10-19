using System;

namespace _02.Multiply_an_Array_of_Doubles
{
    class MultiplyAnArrayOfDoubles
    {
        static void Main()
        {
            string[] stringArr = Console.ReadLine().Split(' ');   // по този начин при прочитането на стирнга от конзолата се split ва по space.
            double[] arr = new double[stringArr.Length];       // на този ред си създаваме масив от double който е с дължина равна на масива(array) от от strings на горния ред! 

            for (int i = 0; i < arr.Length; i++)        // въртейки for cycle ние прехвърляме( double.Parse() ваме) една по една стойностите на масива string в double масива
            {
                arr[i] = double.Parse(stringArr[i]);    // като използваме i в масива ние въртиме и показваме в коя клетка сме в масива - i - 0, i - 1, i - 2 и т.н и презаписваме в нея новата стойност
            }

            var p = double.Parse(Console.ReadLine());   // на този ред прочетаме стойността на р с който ще умножаваме всяка една стойност в масива arr. 

            for (int i = 0; i < arr.Length; i++)        // въртейки масива през for ние умножаваме всяка една стойност от масива по р и презаписваме обратно нейната стойност.
            {
                arr[i] *= p;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
 