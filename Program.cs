using System;
class Program{
    static void Main (string[]args){
        double x1, x2, y1, y2, r1, r2;
        x1 = double.Parse(Console.ReadLine());
        y1 = double.Parse(Console.ReadLine());
        x2 = double.Parse(Console.ReadLine());
        y2 = double.Parse(Console.ReadLine());
        r1 = double.Parse(Console.ReadLine());
        r2 = double.Parse(Console.ReadLine());
        double d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
        if(d<= r1 + r2){
            double a, h, x3, y3, x4, y4, x5, y5;
            a = (Math.Pow(r1, 2) - Math.Pow(r2, 2) + Math.Pow(d, 2)) / (2 * d);
            h = Math.Sqrt(Math.Pow(r1, 2) - Math.Pow(a, 2));
            x3 = x1 + a * (x2 - x1) / d;
            y3 = y1 + a * (y2 - y1) / d;
            x4 = x3 - h * (y2 - y1) / d;
            y4 = y3 + h * (x2 - x1) / d;
            x5 = x3 + h * (y2 - y1) / d;
            y5 = y3 - h * (x2 - x1) / d;

             if(d == r1 +r2){
            Console.WriteLine(x4);
            Console.WriteLine(y4);
            }
            else{
            Console.WriteLine(x4); 
            Console.WriteLine(y4);
            Console.WriteLine(x5);
            Console.WriteLine(y5);
            }
        }
       
    }
}
