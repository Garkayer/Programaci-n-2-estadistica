using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación_2_estadistica
{
    class estadistica
    {
        public double suma = 0;

        public double media(String[] serie)
        {
            foreach (String valor in serie)
            {
                suma += int.Parse(valor);
            }
            return suma / serie.Length;


        }
    }
}
