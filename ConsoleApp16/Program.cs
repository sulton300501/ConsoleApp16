using System;

class Program
{
    delegate bool CheckRectangleDelegate(int width, int height);

    static void Main()
    {

        

        CheckRectangleDelegate checkRectangle = ShaklTekshir;
        Action<double, double> action = YuziniTop;

        action += Perimetr;
        

        int width = 5;
        int height = 5;
        
        action(width, height);

        if (checkRectangle(width, height))
        {
            Console.WriteLine("To'rt burchak");

            Perimetr(width, height);
            YuziniTop(width, height);



        }
        else
        {
            Console.WriteLine("To'rt burchak emas");
        }





    }

    static bool ShaklTekshir(int width, int height)
    {
        return width == height;
    }

    static void Perimetr(double x, double y)
    {
        double perimetr = x * y;
        Console.WriteLine($" Perimetr : {perimetr}");
    }

    static void YuziniTop(double x, double y)
    {
        double yuzini = 2*(x*y);
        Console.WriteLine($" Yuzasi : {yuzini}");
    }






}
