﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1066
{
    internal class Program
    {
        static void Main(string[] args) {

            int valorPar, valorImpar, valorPositivo, valorNegativo, num, i;

            valorPar = 0;
            valorImpar = 0;
            valorPositivo = 0;
            valorNegativo = 0;

            for (i = 1; i <= 5; i++) {

                num = int.Parse(Console.ReadLine());

                if(num % 2 == 0) {

                    valorPar++;

                } else {

                    valorImpar++;
                }

                if(num > 0) {
                    valorPositivo++;

                } else if (num < 0) {

                    valorNegativo++;
                }
            }

            Console.WriteLine(valorPar + " valor(es) par(es)");
            Console.WriteLine(valorImpar + " valor(es) impar(es)");
            Console.WriteLine(valorPositivo + " valor(es) positivo(s)");
            Console.WriteLine(valorNegativo + " valor(es) negativo(s)");

        }
    }
}
