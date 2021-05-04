using System;
using GeradorDePeçasVidroGCode;
using GeradorDePeçasVidroGCode.Entities;
using GeradorDePeçasVidroGCode.Entities.Ferragens;
using System.Globalization;

namespace GeradorDePeçasVidroGCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Ferragem1520 ferragem1520 = new Ferragem1520();

            PecaVidro peca = new PecaVidro();
            Console.WriteLine("Digite a largura da peça:");
            peca.Largura = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura da peça:");
            peca.Altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura da fechadura:");
            ferragem1520.AlturaFechadura = int.Parse(Console.ReadLine());

            Ferragem1125 ferragem1125 = new Ferragem1125();
            ferragem1520.Peca = peca;

            ferragem1125.peca = peca;

            Console.WriteLine();
            Console.WriteLine(peca);
            Console.WriteLine(ferragem1125);
            Console.WriteLine(ferragem1520);

       

        }
    }
}
