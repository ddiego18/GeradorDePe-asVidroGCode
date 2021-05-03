using System;
using System.Collections.Generic;
using System.Text;
using GeradorDePeçasVidroGCode;
using GeradorDePeçasVidroGCode.Entities;

namespace GeradorDePeçasVidroGCode.Entities
{
    class Ferragem1125
    {
        public const double DistanciaBordaLateral = 50.0;
        public const double DistanciaBordaSuperior = 20.0;
        public const double RaioFuro = 8.0;

        public PecaVidro peca = new PecaVidro();

       
        
        double roldanaEsquerdaX;

        public double RoldanaEsquerdaX()
        {
            roldanaEsquerdaX = DistanciaBordaLateral - RaioFuro;
            return roldanaEsquerdaX;
        }

        double roldanaDireitaX;
        public double RoldanaDireitaX()
        {
            roldanaDireitaX = peca.Largura - DistanciaBordaLateral - RaioFuro;
            return roldanaDireitaX;
        }

        double roldanaY;

        public double RoldanaY()
        {
            roldanaY = peca.Altura - DistanciaBordaSuperior;
            return roldanaY;
        }

        public override string ToString()
        {
            return "G0 X" + RoldanaEsquerdaX() + " Y" + RoldanaY() + "\n"
                + "G2 X" + RoldanaEsquerdaX() + " Y" + RoldanaY() + "I" + RaioFuro + "\n"
                + "G0 X" + RoldanaDireitaX() + " Y" + RoldanaY() + "\n"
                + "G2 X" + RoldanaDireitaX() + " Y" + RoldanaY() + "I" + RaioFuro;
        }
    }
}
