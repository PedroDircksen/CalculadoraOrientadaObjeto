using System;

namespace calculadoraObjeto
{
    public class Calculadora
    {
        public double ResultadoSoma;
        public double ResultadoSubtracao;
        public double ResultadoMultiplicacao;
        public double ResultadoDivisao;
        public string[] historico = new string[30];
        public int posicaoLivreHistorico = 0;

        public double Somar(double numero1, double numero2)
        {
            string conta = $"{numero1} + {numero2} = {numero1+numero2}";
            historico[posicaoLivreHistorico] = conta;
            posicaoLivreHistorico++;
            return numero1 + numero2;
        }

        public double Subtrair(double numero1, double numero2)
        {
            string conta = $"{numero1} + {numero2} = {numero1 - numero2}";
            historico[posicaoLivreHistorico] = conta;
            posicaoLivreHistorico++;
            return numero1 - numero2;
        }

        public double Multiplicar(double numero1, double numero2)
        {
            string conta = $"{numero1} + {numero2} = {numero1 * numero2}";
            historico[posicaoLivreHistorico] = conta;
            posicaoLivreHistorico++;
            return numero1* numero2;
        }

        public double Dividir(double numero1, double numero2)
        {
            string conta = $"{numero1} + {numero2} = {numero1 / numero2}";
            historico[posicaoLivreHistorico] = conta;
            posicaoLivreHistorico++;
            return  numero1 / numero2;
        }

        public void MostrarHistorico()
        {
            for (int i = 0; i < posicaoLivreHistorico; i++)
            {
                Console.WriteLine(historico[i]);
            }
        }        
    }
}


