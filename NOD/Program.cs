using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NOD
{
    class Program
    {
        static void Main()
        {
            Fraction a;
            a.num = 5;
            a.denom = 3;
            a.Cutt();
            Console.Write("a = ");
            a.Print();
            Console.WriteLine();

            Fraction x;
            x.num = 25;
            x.denom = 10;
            x.Cutt();
            Console.Write("x = ");
            x.Print();
            Console.WriteLine();

            Console.WriteLine();

            //Multiplication
            //Method
            Fraction y = a.Multiplication(x);
            a.Print();
            Console.Write(" * ");
            x.Print();
            Console.Write(" = ");
            y.Print();
            Console.Write("    with method");
            Console.WriteLine();

            //Operator
            a.Print();
            Console.Write(" * ");
            x.Print();
            Console.Write(" = ");
            y = a * x;
            y.Print();
            Console.Write("    with operator");
            Console.WriteLine();

            Console.WriteLine();
           
            //Division
            //Method
            Fraction z = a.Devisoin(x);
            a.Print();
            Console.Write(" / ");
            x.Print();
            Console.Write(" = ");
            z.Cutt();
            z.Print();
            Console.Write("     with method");
            Console.WriteLine();

            //Operator
            a.Print();
            Console.Write(" / ");
            x.Print();
            Console.Write(" = ");
            z = a / x;
            z.Print();
            Console.Write("     with operator");
            Console.WriteLine();

            Console.WriteLine();

            //Adding
            //Method
            Fraction e = a.Adding(x);
            a.Print();
            Console.Write(" + ");
            x.Print();
            Console.Write(" = ");
            e.Cutt();
            e.Print();
            Console.Write("    with method");
            Console.WriteLine();

            //Operator
            a.Print();
            Console.Write(" + ");
            x.Print();
            Console.Write(" = ");
            e = a + x;
            e.Print();
            Console.Write("    with operator");
            Console.WriteLine();

            Console.WriteLine();

            //Subtraction
            //Method
            Fraction r = a.Away(x);
            a.Print();
            Console.Write(" - ");
            x.Print();
            Console.Write(" = ");
            r.Cutt();
            r.Print();
            Console.Write("    with method");
            Console.WriteLine();

            //Operator
            a.Print();
            Console.Write(" - ");
            x.Print();
            Console.Write(" = ");
            r = a - x;
            r.Print();
            Console.Write("    with operator");
            Console.WriteLine();

            Console.ReadLine();
        }

        struct Fraction
        {
            public int num, denom;
            private int nod(int a, int b)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);

                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
                return a;
            }

            public void Print()
            {
                if (denom < 0)
                {
                    if (num < 0)
                        Console.Write("({0})/({1})", num, denom);

                    if (num > 0)
                        Console.Write("{0}/({1})", num, denom);
                }
                else
                {
                    if (denom == 0)
                        Console.Write("ERROR!!!");

                    if (denom == 1)
                        if (num > 0)
                            Console.Write(num);
                        else
                            Console.Write("({0})", num);

                    if (denom > 0 && denom != 1)
                        Console.Write("{0}/{1}", num, denom);
                }
            }

            public void Cutt()
            {
                ChangeSingh();

                int a = nod(num, denom);
                this.num /= a;
                denom /= a;
            }

            //Multiplication
            public Fraction Multiplication(Fraction b)
            {
                Fraction c;
                c.num = num * b.num;
                c.denom = denom * b.denom;
                c.Cutt();
                c.ChangeSingh();

                return c;
            }

            public static Fraction operator *(Fraction a, Fraction b)
            {
                Fraction c;
                c.num = a.num * b.num;
                c.denom = a.denom * b.denom;
                c.Cutt();
                c.ChangeSingh();
                return c;
            }


            //Division
            public Fraction Devisoin(Fraction b)
            {
                Fraction c;
                c.num = num * b.denom;
                c.denom = denom * b.num;
                c.Cutt();
                c.ChangeSingh();

                return c;
            }

            public static Fraction operator /(Fraction a, Fraction b)
            {
                Fraction c;
                c.num = a.num * b.denom;
                c.denom = a.denom * b.num;
                c.Cutt();
                c.ChangeSingh();
                return c;
            }

            public void ChangeSingh()
            {
                if (denom < 0)
                {
                    num = -num;
                    denom = -denom;
                }
            }

            //Adding
            public Fraction Adding(Fraction b)
            {
                Fraction c = new Fraction();

                if (denom != b.denom)
                {
                    c.num = num * b.denom + b.num * denom;
                    c.denom = denom * b.denom;
                }
                else
                    if (denom == 0 || b.denom == 0)
                    {
                        Console.WriteLine("ERROR!!!");
                    }
                    else
                {
                    c.num = num + b.num;
                }

                return c;
            }

            public static Fraction operator +(Fraction a, Fraction b)
            {
                Fraction c = new Fraction();

                if (a.denom != b.denom)
                {
                    c.num = a.num * b.denom + b.num * a.denom;
                    c.denom = a.denom * b.denom;
                }

                else
                    if (a.denom == 0 || b.denom == 0)
                    {
                        Console.WriteLine("ERROR!!!");
                    }
                    else
                    {
                        c.num =a.num + b.num;
                    }

                return c;
            }

            //Subtraction
            public Fraction Away(Fraction b)
            {
                Fraction c = new Fraction();

                if (denom != b.denom)
                {
                    c.num = num * b.denom - b.num * denom;
                    c.denom = denom * b.denom;
                }
                else
                    if (denom == 0 || b.denom == 0)
                    {
                        Console.WriteLine("ERROR!!!");
                    }
                    else
                    {
                        c.num = num + b.num;
                    }

                return c;
            }

            public static Fraction operator -(Fraction a, Fraction b)
            {
                Fraction c = new Fraction();

                if (a.denom != b.denom)
                {
                    c.num = a.num * b.denom - b.num * a.denom;
                    c.denom = a.denom * b.denom;
                }
                else
                    if (a.denom == 0 || b.denom == 0)
                    {
                        Console.WriteLine("ERROR!!!");
                    }
                    else
                    {
                        c.num = a.num + b.num;
                    }

                return c;
            }

        }
    }

}
