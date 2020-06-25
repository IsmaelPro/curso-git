using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Course
{
    class ConversorMoeda
    {
        public static double Iof = 6.00;
        
        

        public static double Conversao(double cot, double qte)
        {
            double x = cot * qte;
            double valor = (x / 100) * Iof + x;
            return valor; 
        }
    }
}
