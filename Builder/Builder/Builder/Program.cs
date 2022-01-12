using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // содаем объект Завод
            Factory factory = new Factory();
            // создаем билдер для японского авто
            CarBuilder builder = new JapCarBuilder();
            // Создаем
            Car japCar = factory.Fact(builder);
            Console.WriteLine(japCar.ToString());
            // создаем билдер для немецкого авто
            builder = new GerCarBuilder();
            Car gerCar = factory.Fact(builder);
            Console.WriteLine(gerCar.ToString());

            Console.ReadKey();
        }
    }
}
