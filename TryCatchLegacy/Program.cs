using System;

namespace TryCatchLegacy
{
    internal class Program
    {
        private readonly static Calculator calculator = new Calculator();
        static void Main(string[] args)
        {
            try
            {

                //Division();
                Add();
                //AddNull();
              
             
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Impossibile eseguire una divisione per zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        public static void Division()
        {
            var result = calculator.Division(-1, 1);
            Console.WriteLine(result);
        }

        public static void Add()
        {
            var numbers = new int[4];
            numbers[0] = 2;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 5;
                
            var result = calculator.Add(numbers);

            Console.WriteLine(result);
        }

        public static void AddNull()
        {
            try
            {
                int[] numbers = null;

                var result = calculator.Add(numbers);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
