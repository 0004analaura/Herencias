using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 128;
            double n2 = 8;
            Calculadora calc = new Calculadora("Casio", "fx-50");
            double total = calc.Sumar(n1, n2);
            Console.WriteLine(total);
            double diferencia = calc.Restar(n1, n2);
            Console.WriteLine(diferencia);



            CalculadoraCientifica cientifica = new CalculadoraCientifica("Xiaomi", "CalX");
            double raiz = cientifica.Raiz(n1);
            Console.WriteLine(raiz);

            double potencia = cientifica.Potencia(n1, n2);
            Console.WriteLine(potencia);

            double modulo = cientifica.Modulo(n1, n2); 
                Console.WriteLine(modulo);

            double logaritmo = cientifica.Logaritmo(n1);
            Console.WriteLine(logaritmo);

            MostrarTipo(calc);
            MostrarTipo(cientifica);

            Console.ReadLine();

        }
        public static  void MostrarTipo(Calculadora calculadora)
        {
            Console.WriteLine(calculadora.Tipo());
        }
    }

    public class Calculadora
    {
        public Calculadora()
        {
        }

        public string Marca { get; set; }
        public string Serie { get; set; }

        public Calculadora(string marca, string serie)
        {
            Marca = marca;
            Serie = serie;
        }

        public double Sumar(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Restar(double n1, double n2)
        {
            return n1 - n2; 
        }

        public double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }

        public string Tipo()
        {
            return "Calculadora Basica";
        }
    }

    public class CalculadoraCientifica : Calculadora
    {
        public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
        {
        }

        public double Potencia(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }

        public double Raiz(double n1)
        {
            return Math.Sqrt(n1);
        }

        public double Modulo(double n1, double n2)
        {
            return Math.Abs(n1 % n1);
        }

        public double Logaritmo(double n1)
        {
            return Math.Log10(n1);
        } 

        public virtual string Tipo()
        {
            return "Cientifica";
        }
    }
}
