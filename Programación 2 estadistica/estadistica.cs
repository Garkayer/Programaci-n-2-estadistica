﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación_2_estadistica
{
    class estadistica
    {
        

        public double media(String[] serie)
        {
            double suma = 0;
            foreach (string valor in serie)
            {
                suma += int.Parse(valor);
            }
            return suma / serie.Length;
        }
        public double estandar(String[] serie)
        {
            double media_aritmetica = media(serie),
                suma = 0;
                
            foreach (string valor in serie)
            {
                suma += Math.Pow(double.Parse(valor) - media_aritmetica, 2);
            }
            return suma / serie.Length;
        }
        public double tipica(String[] serie)
        {
            return Math.Sqrt(estandar(serie));
        }
    }
}