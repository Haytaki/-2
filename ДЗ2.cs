using System;

namespace ConsoleApp1
{
    class Program
    {
        // Болотова Анна
        // Написать метод, возвращающий минимальное из трех чисел.

        static void Main(string[] args)
        {

            /* Console.WriteLine("Введи число");
             int a = int.Parse(Console.ReadLine());
             Console.WriteLine("Введи число");
             int b = int.Parse(Console.ReadLine());
             Console.WriteLine("Введи число");
             int c = int.Parse(Console.ReadLine());

             if (a < b && a < c)
                 Console.WriteLine("Наименьшее число " + a);
             else if (b < a && b < c)
                 Console.WriteLine("Наименьшее число " + b);
             else
                 Console.WriteLine("Наименьшее число " + c);

             Console.ReadLine();



             //Написать метод подсчета количества цифр числа.

             Console.WriteLine("Введи число");

             int n = int.Parse(Console.ReadLine());
             int i = 0;

             while (n != 0)
             {
                 i++;
                 n = n / 10;	
             }
             if (i == 1)
                 Console.WriteLine("В числе " + i + " знак");
             else if (i >= 2 && i <= 4)
                 Console.WriteLine("В числе " + i + " знака");
             else
                 Console.WriteLine("В числе " + i + " знаков");


             // Как сделать так, что бы выводилось "В Числе n i знаков"??
             // Больше 10 знаков не работает, почему??

             Console.ReadLine(); 
      
            //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

            Console.WriteLine("Введи целое число");
            int x = int.Parse(Console.ReadLine());
            int y = x % 2 == 0 ? 0 : 1;
            int i = 0;

            while(x != 0)
            {
                if (y == 1)
                {
                    i += x;
                    Console.WriteLine("Введи целое число");
                    Console.ReadLine();
                }
                else if (y == 0)
                    continue;
                else
                {
                    Console.WriteLine("Вы ввели 0");
                    Console.WriteLine(i);
                }
            }

            // Не понимаю как это сделать ((

            Console.ReadLine();
            
   
            //Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            //Используя метод проверки логина и пароля, написать программу: 
            //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            //С помощью цикла do while ограничить ввод пароля тремя попытками.

            Console.WriteLine("Введи логин");
            string login = Console.ReadLine();
            Console.WriteLine("Введи пароль");
            string Password = Console.ReadLine();
            Console.WriteLine("Выполняется проверка...");
            Console.WriteLine("");

            if (login == "root")
            {
                if (Password == "GeekBrains")
                {
                    Console.WriteLine("Добро пожаловать =)");
                    Console.ReadLine();
                }
                else
                {
                    int a = 2;
                    do
                    {
                        Console.WriteLine("Ошибка в логин или пароль. Попробуй снова");
                        Console.WriteLine("Введи логин");
                        login = Console.ReadLine();
                        Console.WriteLine("Введи пароль");
                        Password = Console.ReadLine();
                        if (a == 2)
                            Console.WriteLine("Остлось " + a + " попытки");
                        else
                            Console.WriteLine("Остлась " + a + " попытка");
                        a--;
                    }
                    while (a != 0);
                    Console.WriteLine("Заблокировано!!");
                    Console.WriteLine("Доступ запрещен");
                    Console.ReadLine();
                }
            }
            else
            {
                int a = 2;
                do
                {
                    Console.WriteLine("Ошибка в логин или пароль. Попробуй снова");
                    Console.WriteLine("");
                    Console.WriteLine("Введи логин");
                    login = Console.ReadLine();
                    Console.WriteLine("Введи пароль");
                    Password = Console.ReadLine();
                    if (a == 2)
                        Console.WriteLine("Остлось " + a + " попытки");
                    else
                        Console.WriteLine("Остлась " + a + " попытка");
                    a--;
                }
                while (a > 0);
                Console.WriteLine("Заблокировано!!");
                Console.WriteLine("Доступ запрещен");

                //небольшой косяк с попытками. Не понимаю как исправить

                Console.ReadLine();
            }



            //Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
            //нужно ли человеку похудеть, набрать вес или все в норме;
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.


            Console.WriteLine("Сколько ты весишь в кг?");
            int mass = int.Parse(Console.ReadLine());
            Console.WriteLine("Какой твой рост в метрах?");
            int growth = int.Parse(Console.ReadLine());

            double bmi = mass / (growth * growth);            

            if (bmi < 16)
                Console.WriteLine("Выраженный дефицит массы");

            else if(bmi >= 16 && bmi <= 18,5)
                Console.WriteLine("Недостаточная масса тела");
            
            else if (bmi >= 19 && bmi <= 25)
                Console.WriteLine("Норма");

            else if (bmi >= 25,5 && bmi <= 30)
                Console.WriteLine("Избыточная масса тела");
            
            else if (bmi >= 30,5 && bmi <= 35)
                Console.WriteLine("Ожирение первой степени");
            
            else if (bmi >= 35,5 && bmi <= 40)
                Console.WriteLine("Ожирение второй степени");
            
            else
                Console.WriteLine("Ожирение третьей степени");

            // Не понимаю как пeревести bmi в число

            Console.ReadLine();

 */
        }
    }
}

