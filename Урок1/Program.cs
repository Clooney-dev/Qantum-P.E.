using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

class Newton
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите массу тела: ");
        var m = Convert.ToInt32(Console.ReadLine());
        #region Проверка
       
        
            if (m <= 0)
            {
            try
            {
                throw new ArgumentNullException();
            }
            catch (ArgumentNullException) { Console.WriteLine("Вес не может быть меньше или равен нулю"); }

               

            }
        else
        {
            Console.WriteLine("Всё правильно");

        }
        #endregion
        Console.WriteLine();
        var c = 300000000;
        var c1 = Convert.ToInt64(Math.Pow(c, 2));



        var E = m * c1;
        Console.WriteLine(E);
        Console.ReadLine();





    }
} 




     