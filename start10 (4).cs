using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start1
{
    class Program
    {
        static void Main(string[] args)
        {
            start21();
        }
        static void start0()
        {
            int hp = 100;
            int damage = 10;
            hp = hp - damage;
            Console.WriteLine(hp);
        }
        static void start1()
        {
            int a = 20;
            int P = 4 * a;
            Console.WriteLine(P);
        }
        static void start2()
        {
            int a = 10;
            int S = a * a;
            Console.WriteLine(S);
        }
        static void start3()
        {
            int a = 5;
            int b = 10;
            int S = a * b;
            int P = 2 * (a + b);
            Console.WriteLine(S);
            Console.Write(P);
        }
        static void start4()
        {
            int d = 10;
            double l = d * Math.PI;
            Console.WriteLine(l);
        }
        static void start5()
        {
            int a = 4;
            int V = a * a * a;
            int S = 6 * a * a;
            Console.WriteLine(V);
            Console.WriteLine(S);
        }
        static void start6()
        {
            int a = 4;
            int b = 8;
            int c = 5;
            int V = a * b * c;
            int S = 2 * (a * b + b * c + a * c);
            Console.WriteLine(V);
            Console.WriteLine(S);
        }
        static void start7()
        {
            int R = 10;
            double L = 2 * Math.PI * R;
            double S = Math.PI * R * R;
            Console.WriteLine(L);
            Console.WriteLine(S);
        }
        static void start8()
        {
            int a = 3;
            int b = 4;
            int K = (a + b) / 2;
            Console.WriteLine(K);
        }
        static void start9()
        {
            int a = 4;
            int b = 3;
            double F = Math.Sqrt(a * b);
            Console.WriteLine(F);
        }
        static void start10()
        {
            int a = 4;
            int b = 3;
            int Q = a + b;
            int W = a - b;
            double R = a ^ 2 * b ^ 2;
            Console.WriteLine(Q);
            Console.WriteLine(W);
            Console.WriteLine(R);

        }
        static void start11()
        {
            int a = 5;
            int b = 6;
            int Q = a + b;
            int W = a - b;
            double R = Math.Abs(a * b);
            Console.WriteLine(Q);
            Console.WriteLine(W);
            Console.WriteLine(R);
        }
        static void start12()
        {
            int a = 4;
            int b = 2;
            double c = Math.Sqrt(a ^ 2 + b ^ 2);
            double P = Math.Sqrt(a + b + c);
            Console.WriteLine(c);
            Console.WriteLine(P);
        }
        static void start13()
        {
            int R1 = 6;
            int R2 = 4;
            double S1 = Math.PI * (R1 * R1);
            double S2 = Math.PI * (R2 ^ R2);
            double S3 = S1 - S2;
            Console.WriteLine(S1);
            Console.WriteLine(S2);
            Console.WriteLine(S3);
        }
        static void start14()
        {
            int L = 4;
            double R = 2 * Math.PI * L;
            double S = Math.PI * (R * R);
            Console.WriteLine(R);
            Console.WriteLine(S);
        }
        static void start15()
        {
            int S = 4;
            int R = 3;
            double L = 2 * Math.PI * R;
            double D = Math.PI * (R * R);
            Console.WriteLine(L);
            Console.WriteLine(D);
        }
        static void start16()
        {
            int x1 = 3;
            int x2 = 4;
            double K = Math.Abs(x2 - x1);
            Console.WriteLine(K);
        }
        static void start17()
        {
            int A = 1;
            int B = 3;
            int C = 5;
            int c = C - A;
            int b = C - B;
            int e = c + b;
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(e);
        }
        static void start18()
        {
            int A = 1;
            int B = 3;
            int C = 5;
            int c = C - A;
            int b = C - B;
            int e = c * b;
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(e);
        }
        static void start19()
        {
            int x1 = 2;
            int y1 = 3;
            int x2 = 4;
            int y2 = 5;
            int c = Math.Abs(y1 - x1);
            int a = Math.Abs(y2 - y2);
            int P = (a + c) * 2;
            int S = a * c;
            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(P);
            Console.WriteLine(S);

        }
        static void start20()
        {
            int x1 = 2;
            int y1 = 3;
            int x2 = 4;
            int y2 = 5;
            double a = (x2 - x1) * (x2 - x1);
            double b = (y2 - y1) * (y2 - y1);
            double c = a + b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

         }
        static void start21()
        {
            int a = 831;
            int b = a % 10;
            int c = a % 100;
            int g = c / 10;
            
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(g);
            
        }


    }
}



    
