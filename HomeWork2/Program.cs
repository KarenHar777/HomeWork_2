using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataTypes
            

            Console.WriteLine("Data Types");
            Console.WriteLine();

            string name = "Onasis";
            Console.WriteLine("Имя " + name);
            char clothingSize = 'M';
                Console.WriteLine("Размер одежды " + clothingSize);
            bool beMerry = true;
                Console.WriteLine("Состоять в браке " + beMerry);
            byte old = 47;
                Console.WriteLine($"Возраст {old}");
            int howManyCar = 2;
                Console.WriteLine($"Сколько машин {howManyCar}");
            short beerOnYear = 547;
                Console.WriteLine($"Сколько пиво пьёт в году {beerOnYear} литр");
            float carMileage = 37890.86f;
                Console.WriteLine("Пробег автомобиля " + carMileage + " милия");
            double monthlySalary = 4763.7845;
                Console.WriteLine("Месечная зарплата " + monthlySalary + " USD");
            decimal bankAcount = 25698.96452719m;
                Console.WriteLine("Наличия денег в банке " + bankAcount + " USD");


            Console.ReadKey();


        }
    }
}
