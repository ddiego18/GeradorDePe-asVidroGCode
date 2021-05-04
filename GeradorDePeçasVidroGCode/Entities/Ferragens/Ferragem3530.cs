using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using GeradorDePeçasVidroGCode;
using GeradorDePeçasVidroGCode.Entities;

namespace GeradorDePeçasVidroGCode.Entities
{
    class Ferragem3530
    {
        public const double DistBordaFuroMenor = 32.5;
        public const double DistBordaFuroMaior = 37.5;
        public const double DistEntreFuros = 85.0;
        public const int RaioFuroMaior = 15;
        public const int RaioFuroMenor = 10;

        public PecaVidro Peca = new PecaVidro();
        public int AlturaFechadura { get; set; }

        public Ferragem3530()
        {

        }
        public Ferragem3530(int alturaFechadura)
        {
            AlturaFechadura = alturaFechadura;
        }

        double alturaFuroInferior;

        public double AlturaFuroInferior()
        {
            alturaFuroInferior = AlturaFechadura - (DistEntreFuros / 2);
            return alturaFuroInferior;
        }

        double alturaFuroSuperior;

        public double AlturaFuroSuperior()
        {
            alturaFuroSuperior = AlturaFechadura + (DistEntreFuros / 2);
            return alturaFuroSuperior;
        }

        double distBordaFurosMenoresX;

        public double DistBordaFurosMenoresX()
        {
            distBordaFurosMenoresX = Peca.Largura - DistBordaFuroMenor - RaioFuroMenor;
            return distBordaFurosMenoresX;
        }

        double distBordaFuroMaiorX;

        public double DistBordaFuroMaiorX()
        {
            distBordaFuroMaiorX = Peca.Largura - DistBordaFuroMaior - RaioFuroMaior;
            return distBordaFuroMaiorX;
        }

        public override string ToString()
        {
            return "G0 X" + DistBordaFuroMaiorX().ToString(CultureInfo.InvariantCulture) + " Y" + AlturaFechadura + "\n"
                + "G3 X" + DistBordaFuroMaiorX().ToString(CultureInfo.InvariantCulture) + " Y" + AlturaFechadura + "I" + RaioFuroMaior + "\n"
                + "G0 X" + DistBordaFurosMenoresX().ToString(CultureInfo.InvariantCulture) + " Y" + AlturaFuroInferior().ToString(CultureInfo.InvariantCulture) + "\n"
                + "G3 X" + DistBordaFurosMenoresX().ToString(CultureInfo.InvariantCulture) + " Y" + AlturaFuroInferior().ToString(CultureInfo.InvariantCulture) + "I" + RaioFuroMenor + "\n"
                + "G0 X" + DistBordaFurosMenoresX().ToString(CultureInfo.InvariantCulture) + " Y" + AlturaFuroSuperior().ToString(CultureInfo.InvariantCulture) + "\n"
                + "G3 X" + DistBordaFurosMenoresX().ToString(CultureInfo.InvariantCulture) + " Y" + AlturaFuroSuperior().ToString(CultureInfo.InvariantCulture) + "I" + RaioFuroMenor;
        }

    }
}
