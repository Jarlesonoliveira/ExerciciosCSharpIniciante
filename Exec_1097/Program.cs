﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1097
{
    internal class Program
    {
        static void Main(string[] args) {

            int I, J;
            I = 1;
            J = 7;

            do {

                for (int e = 0; e < 3; e++) {

                    Console.WriteLine("I=" + I + " J=" + J);

                    J--;
                }

                I += 2;
                J += 5;

            } while (J <= 15);
        }
    }
}
