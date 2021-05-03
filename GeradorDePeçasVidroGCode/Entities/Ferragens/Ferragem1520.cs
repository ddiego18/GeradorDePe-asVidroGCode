using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace GeradorDePeçasVidroGCode.Entities.Ferragens
{
    class Ferragem1520
    {
        public const int AlturaRecorte = 75;
        public const int LarguraRecorte = 43;
        public const int RaioRecorte = 9;
        public int AlturaFechadura;

        public PecaVidro Peca = new PecaVidro();

        public Ferragem1520()
        {

        }
        public Ferragem1520(int alturaFechadura)
        {
            AlturaFechadura = alturaFechadura;
        }

        double distanciaBordaInicioRaio;

        public double DistanciaBordaInicioRaio()
        {
            distanciaBordaInicioRaio = (Peca.Largura - LarguraRecorte) + RaioRecorte;
            return distanciaBordaInicioRaio;
        }

        double alturaRecorteInferior;

        public double AlturaRecorteInferior()
        {
            alturaRecorteInferior = AlturaFechadura - (AlturaRecorte / 2);
            return alturaRecorteInferior;
        }

        double alturaRecorteSuperior;

        public double AlturaRecorteSuperior()
        {
            alturaRecorteSuperior = AlturaFechadura + (AlturaRecorte / 2);
            return alturaRecorteSuperior;
        }

        double alturaRecorteInferiorMaisRaio;

        public double AlturaRecorteInferiorMaisRaio()
        {
            alturaRecorteInferiorMaisRaio = AlturaRecorteInferior() + RaioRecorte;
            return alturaRecorteInferiorMaisRaio;
        }

        double alturaRecorteSuperiorMenosRaio;

        public double AlturaRecorteSuperiorMenosRaio()
        {
            alturaRecorteSuperiorMenosRaio = AlturaRecorteSuperior() - RaioRecorte;
            return alturaRecorteSuperiorMenosRaio;
        }

        double distanciaBordaLarguraRecorte;

        public double DistanciaBordaLarguraRecorte()
        {
            distanciaBordaLarguraRecorte = Peca.Largura - LarguraRecorte;
            return distanciaBordaLarguraRecorte;
        }

        public override string ToString()
        {
            return "G0 X" + Peca.Largura + " Y" + AlturaRecorteInferior().ToString(CultureInfo.InvariantCulture) + "\n"
                + "G1 X" + Peca.Largura + " Y" + AlturaRecorteInferior().ToString(CultureInfo.InvariantCulture) + "\n"
                + "G1 X" + DistanciaBordaInicioRaio().ToString(CultureInfo.InvariantCulture) + "\n"
                + "G2 X" + DistanciaBordaLarguraRecorte().ToString(CultureInfo.InvariantCulture) + " Y" + AlturaRecorteInferiorMaisRaio().ToString(CultureInfo.InvariantCulture) + " R " + RaioRecorte + "\n"
                + "G1 Y" + AlturaRecorteSuperiorMenosRaio().ToString(CultureInfo.InvariantCulture) + "\n"
                + "G2 X" + DistanciaBordaInicioRaio().ToString(CultureInfo.InvariantCulture) + " Y" + AlturaRecorteSuperior().ToString(CultureInfo.InvariantCulture) + " R " + RaioRecorte + "\n"
                + "G1 X" + Peca.Largura;
        }
    }
}
