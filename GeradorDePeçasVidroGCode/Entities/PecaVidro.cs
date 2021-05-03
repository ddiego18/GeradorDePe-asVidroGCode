using System;
using System.Collections.Generic;
using System.Text;
using GeradorDePeçasVidroGCode;
using GeradorDePeçasVidroGCode.Entities;
using GeradorDePeçasVidroGCode.Entities.Ferragens;

namespace GeradorDePeçasVidroGCode.Entities
{
    class PecaVidro
    {
        public int Largura { get; set; }
        public int Altura { get; set; }

        public PecaVidro()
        {

        }

        public PecaVidro(int largura, int altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public override string ToString()
        {
            return "G0 X0 Y0" + "\n"
                +"G1 X" + Largura + "\n"
                +"G1 Y" + Altura + "\n"
                +"G1 X0" + "\n"
                +"G1 Y0";
        }
    }
}
