using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Ejercicio 1: Operaciones aritmeticas ");


            Console.Write("Ingrese primer numero  ");
            int n1 = Convert.ToInt16(Console.ReadLine());


            Console.Write("Ingrese segundo numero  ");
            int n2 = Convert.ToInt16(Console.ReadLine());

            int suma = n1 + n2;
            Console.WriteLine(n1 + "+ " + n2 + "=" + suma);

            int resta = n1 - n2;
            Console.WriteLine(n1 + "- " + n2 + "=" + resta);

            int mul = n1 * n2;
            Console.WriteLine(n1 + "* " + n2 + "=" + mul);

            int division = n1 / n2;
            Console.WriteLine(n1 + " / " + n2 + "=" + division);

            int mod = n1 % n2;
            Console.WriteLine(n1 + " mod  " + n2 + "=" + mod);

            

            
            Convert.ToDouble(n1);
            Convert.ToDouble(n2);

            double n3 = Convert.ToDouble(n1);

            double n4 = Convert.ToDouble(n2);
            double div = n3 / n4;

            Console.WriteLine(n1 + " / " + n2 + "=" + div);

            Console.WriteLine("");
            Console.WriteLine("Ejercicios 02 Operaciones Booleanas");


            bool mayor = false, menor = false, igual = false;

            mayor = n1 > n2;
            menor = n1 < n2;
            igual = n1 == n2;

            Console.WriteLine($"{n1} > {n2} = {mayor}");
            Console.WriteLine($"{n1} < {n2} = {menor}");
            Console.WriteLine($"{n1} == {n2} = {igual}");

            Console.WriteLine("Ejercicio 03 Jerarquia de operaciones ");

            double a, b, c, i, ii, iii, iV;

            Console.WriteLine("Ingrese numero a ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese numero b ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese numero c ");
            c = Convert.ToDouble(Console.ReadLine());

            i = a * b + c;
            ii = a * (b + c);
            iii = Math.Round(a / (b * c),2);
            iV =  Math.Round((3*a +(2*b)) / Math.Pow(c,2),2);

            Console.WriteLine($"i. {a} * {b} + {c}+ 3 = {i}");
            Console.WriteLine($"ii. {a} ({b} + {c}) = {ii}");
            Console.WriteLine($"iii. {a} /{b}* {c} = {iii}");
            Console.WriteLine($"iv. 3*{a} +2*{b}/ {c}² = {iV}");

            Console.WriteLine("Ejercicio 04 Expresion cuadratica ");
           

            double numbero2, numbero3;
           

            numbero2 = (-b + Math.Sqrt(b * b) )- (4 -( a * c)) / (2 * a);
            numbero3 = (b + Math.Sqrt(b*b)) - (4 - (a * c)) / (2 * a);
            Console.WriteLine("El resultado de la expresion cuadratica es x1:" + numbero2);
            Console.WriteLine("El resultado de la expresion cuadratica es x2:" + numbero3);


            Console.ReadKey();



        }
    }
}
