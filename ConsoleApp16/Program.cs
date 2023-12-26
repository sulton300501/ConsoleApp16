using ConsoleApp16;
using System;

class Program
{

    public class Person
    {
    
        public delegate double MyDelegate(double a , double b);

        


        static void Main(string[] args)
        {

            MyReally myReally = new MyReally();




            MyDelegate my = new MyDelegate(myReally.Add);
            MyDelegate my2 = new MyDelegate(myReally.Substract);
            MyDelegate my3 = new MyDelegate(myReally.Divide);
            MyDelegate my4 = new MyDelegate(myReally.Square);



            MyDelegate test = my;
            MyDelegate test1 = my2;
            MyDelegate test2 = my3;
            MyDelegate test3 = my4;

            double value = my.Invoke(10, 5);
            double value2 = my2.Invoke(10, 5);
            double value3 = my3.Invoke(10, 5);
            double value4 = my4.Invoke(10, 5);

            Console.WriteLine(value);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);

           

          
            


           /* static void Sulton(string a, MyDelegate b)
            {
                *//*b.Invoke(12, 33);*//*
                MethodA(11,22);
                
            }*/




           /* static  void MethodA(int a , int b)
        {
            Console.WriteLine(a+b);
        }*/

        

    }





}




    
}