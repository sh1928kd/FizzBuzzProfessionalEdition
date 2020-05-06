using System;
using sh1928kd.FizzBuzzProfessionalEdition.Core;

namespace sh1928kd.FizzBuzzProfessionalEdition.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: argsからルールを判断
            var fizzbuzz = new FizzBuzzDelegate();
            FizzBuzzStyle.BuildSimpleFizzBuzzRule(fizzbuzz);

            // TODO: argsから入力を判断
            var result = fizzbuzz.GenerateOneFor(100);

            // TODO: argsから出力を判断
            Console.WriteLine(String.Join("\n", result));
        }
    }
}
