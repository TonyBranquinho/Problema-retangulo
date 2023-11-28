using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_retangulo {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura, altura, area, perimetro, diagonal;

            Console.Write("Base do retangulo: ");
            largura = double.Parse(Console.ReadLine(), CI);
            Console.Write("Altura retangulo: ");
            altura = double.Parse(Console.ReadLine(), CI);

            area = largura * altura;
            Console.WriteLine("Area = " + area.ToString("F4", CI));

            perimetro = (largura * 2) + (altura * 2);
            Console.WriteLine("Perimetro = " + perimetro.ToString("F4", CI));

            diagonal = Math.Sqrt((largura * largura) + (altura * altura));
            Console.
                WriteLine("Diagonal = " + diagonal.ToString("F4", CI));

             
    
    }
}
