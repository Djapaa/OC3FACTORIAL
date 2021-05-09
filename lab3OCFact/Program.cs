using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentProc
{
    public class РодительскийПроцесс

    {

        public static void Main(string[] args)

        {

            if (args.Length != 2)

            {
                Console.WriteLine("Выберите функцию:\n1)sin(x); \n2)cos(x); \n3)x^2; \n4)e^x; \n5)ln(x);\n6)Factorial(x) \n0)Выход;\n");
                Console.WriteLine("Использование:");

                Console.WriteLine(string.Format("\t{0} [Номер выбранной ф-ции] [Номер выбранной ф-ции]", System.Reflection.Assembly.GetEntryAssembly().Location));

                return;

            }

            double step = 1;
            double xmax = 11;
            double xmin = 1;
            double y = 0;
            for (int i = 0; i <= args.Length; i++)
            {
                if (args[i] == "1")

                {
                    for (double x = xmin; x < xmax; x += step)
                    {
                        y = Math.Sin(x);
                        Console.WriteLine("Sin({0})={1}", x, y);
                    }
                }
                else if (args[i] == "2")

                {
                    for (double x = xmin; x < xmax; x += step)
                    {
                        y = Math.Cos(x);
                        Console.WriteLine("Cos({0})={1}", x, y);

                    }

                }
                else if (args[i] == "3")

                {
                    for (double x = xmin; x < xmax; x += step)
                    {
                        y = x * x;
                        Console.WriteLine("x^2({0})={1}", x, y);
                    }
                }
                else if (args[i] == "4")

                {
                    for (double x = xmin; x < xmax; x += step)
                    {
                        y = Math.Exp(x);
                        Console.WriteLine("e^({0})={1}", x, y);
                    }
                }
                else if (args[i] == "5")
                {
                    for (double x = xmin; x < xmax; x += step)
                    {
                        y = Math.Log(x);
                        Console.WriteLine("Log({0})={1}", x, y);
                    }
                }
                if (i == 1)
                    break;
            }


            Process myProcess = new Process();

            Console.WriteLine("Началось выполнение родительского процесса");

            try
            {
                // необходимо для возможности установки переменных окружения

                myProcess.StartInfo.UseShellExecute = false;

                if (((args[0] == "1") && (args[1] == "2")) || ((args[0] == "2") && (args[1] == "1")))
                {
                    args[0] = "Выбранные функции";
                    args[1] = "1 и 2";
                    //   устанавливаем значение переменной окружения
                    //для создаваемого процесса


                    myProcess.StartInfo.EnvironmentVariables[args[0]] = args[1];


                }
                // указываем имя выполняемого файла для нового процесса

                else if (args[0] == "6")
                {
                    Console.WriteLine("введите число");
                    string num = Console.ReadLine();
                    args[0] = "Выбранная функция";
                    args[1] = "6";

                    myProcess.StartInfo.EnvironmentVariables[args[0]] = args[1];
                    myProcess.StartInfo.Environment.Add("Функция", num);

                }

                // и запускаем его

                Console.WriteLine("Дочерний процесс начался!");

                myProcess.StartInfo.FileName = @"C:\Users\esteb\source\repos\lab3OCFact\ChildProc\bin\Debug\ChildProc.exe";

                myProcess.Start();

                // Ждём завершения дочернего процесса

                myProcess.WaitForExit();
                Console.WriteLine("Дочерний процесс завершен!");

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }

        }

    }
}