using System;

namespace kursovaya
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double e, x, s,y;
            decimal z, xk,dx;
            Console.WriteLine("Введите x нач");
            z = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите x кон");
            xk = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг");
            dx = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите точность e");
            e = double.Parse(Console.ReadLine());
            Console.WriteLine(" --------------------------------------------------------------------------------------------");
            Console.WriteLine("|     X      |        ЗНАЧЕНИЕ ФУНКЦИИ           |   КОЛ-ВО ПРОСУММИРОВАННЫХ ЧЛЕНОВ РЯДА     |");
            Console.WriteLine(" --------------------------------------------------------------------------------------------");
            while (z <= xk)
            {
                n = 0; s = 1; y = 0;
                x = Convert.ToDouble(z);
                if (x > 0)
                {
                    while (Math.Abs(s) > e)
                    {
                        s = (Math.Pow((x-1), (2*n + 1))) / ((2*n+1)*Math.Pow((x+1),(2*n+1))); 
                        y += 2*s;
                        n++;
                    }
                   Console.Write("|    " + Convert.ToString(x).PadRight(8) + "|        ");
                   Console.Write(Convert.ToString((y)).PadRight(27) + "|       ");
                   Console.Write(Convert.ToString(n).PadRight(36) + "|");
                   z += dx;
                   Console.WriteLine();
                }
                else z += dx;
            }
            Console.WriteLine(" --------------------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
