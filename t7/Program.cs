using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // دریافت دو عدد از کاربر
            Console.WriteLine("لطفاً عدد اول را وارد کنید:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("لطفاً عدد دوم را وارد کنید:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // دریافت کاراکتر عملیاتی از کاربر
            Console.WriteLine("لطفاً یک کاراکتر عملیاتی وارد کنید (+, -, *, /):");
            char operation = Convert.ToChar(Console.ReadLine());

            // انجام عملیات بر اساس کاراکتر وارد‌شده
            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("تقسیم بر صفر امکان‌پذیر نیست.");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("کاراکتر عملیاتی معتبر نیست.");
                    validOperation = false;
                    break;
            }

            // نمایش نتیجه در صورت معتبر بودن عملیات
            if (validOperation)
            {
                Console.WriteLine($"نتیجه عملیات: {result}");
                Console.ReadKey();
            }
        }
    }
}
