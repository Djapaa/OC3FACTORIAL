
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenProc
{
    public class ДочернийПроцесс

    {
        public static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine(args.Length.ToString() + ' ' + args[0]);
                //Console.ReadKey();
                Process p = Process.GetCurrentProcess();
                //p.StartInfo.EnvironmentVariables[args[0]] = args[1];


                // Получаем текущий процесс

                //Process p = Process.GetCurrentProcess();

                // Получаем блок окружения текущего процесса

                var env = p.StartInfo.EnvironmentVariables;
                double xmax = 11;
                double xmin = 1;
                double y = 0;
                int fact = Convert.ToInt32(env["Функция"]);

                if (Convert.ToBoolean(fact))
                {
                    int f = 1;
                    for (int i = 1; i <= fact; i++)
                        f = f * i;
                    Console.Write("The Factorial of {0} is: {1}\n", fact, f);
                }
                foreach (string key in env.Keys)
                {
                    //Console.WriteLine(key);
                    //Console.WriteLine(env[key]);
                    //Console.WriteLine("key = " + key.ToString() + "  env[" + key.ToString() + "] = " + env[key].ToString());
                    //Console.WriteLine($"!!!! key = {0},env[key] = {1} ", key, env[key]);
                    ////Console.WriteLine(key, env.Keys);
                    if ((key == "Выбранные функции") && (env[key] == "1 и 2"))
                    {
                        for (double x = xmin; x < xmax; x++)
                        {
                            y = Math.Sin(x) * Math.Cos(x);
                            Console.WriteLine("Sin({0})*Сos({0}) = {1}/ key = {2},env[key] = {3} ", x, y, key, env[key]);

                        }
                    }
                    ////if(key = int numb )
                    //// {
                    ////    if (env[key]=6)
                    ////    {
                    ////    }
                    //// }
                    //else if ((key == "Выбранная функция") && (env[key] == "6"))
                    //{
                    //    //Console.WriteLine(env.Keys.ToString());
                    //    Console.WriteLine(key);
                    //    Console.WriteLine(env[key]);
                    //    Console.WriteLine($"key = {0},env[key] = {1} ", key, env[key]);
                    //    int i, f = 1;
                    //    int num = 2;
                    //    Console.WriteLine($"{num}");
                    //    for (i = 1; i <= num; i++)
                    //    
                    //        f = f * i;
                    //        Console.Write("The Factorial of {0} is: {1}\n", num, f);
                    //    }
                    //}
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}









