using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_21_Conversor_Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJ_21_Medidas_Temperatura";

            Fahrenheit f1 = new Fahrenheit(105.2);
            Celsius c1 = new Celsius(24.3);
            Kelvin k1 = new Kelvin(302.3);

            Console.WriteLine("f1 {0:F2} equivale a {1:F2} grados celsius y a {2:F2} grados kelvin", f1.GetTemperatura(), ((Celsius)f1).GetTemperatura(), ((Kelvin)f1).GetTemperatura());
            Console.WriteLine("c1 {0:F2} equivale a {1:F2} grados fahrenheit y a {2:F2} grados kelvin", c1.GetTemperatura(), ((Fahrenheit)c1).GetTemperatura(), ((Kelvin)c1).GetTemperatura());
            Console.WriteLine("k1 {0:F2} equivale a {1:F2} grados fahrenhiet y a {2:F2} grados celsius", k1.GetTemperatura(), ((Fahrenheit)k1).GetTemperatura(), ((Celsius)k1).GetTemperatura());

            f1 = 56.2;
            c1 = 38;
            k1 = 38;

            Console.WriteLine("Ahora f1 {0} - c1 {1} - k1 {2}", f1.GetTemperatura(), c1.GetTemperatura(), k1.GetTemperatura());
            Console.WriteLine("f1 = a c1? {0}\nf1 = a k1? {1}\nf1 != a c1? {2}\nf1 != a k1? {3}", f1 == c1, f1 == k1, f1 != c1, f1 != k1);
            Console.WriteLine("c1 = a f1? {0}\nc1 = a k1? {1}\nc1 != a f1? {2}\nc1 != a k1? {3}", c1 == f1, c1 == k1, c1 != f1, c1 != k1);
            Console.WriteLine("k1 = a f1? {0}\nk1 = a c1? {1}\nk1 != a f1? {2}\nk1 != a c1? {3}", k1 == f1, k1 == c1, k1 != f1, k1 != c1);
            Console.ReadKey();
        }
    }
}
