﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da matriz: ");
            int x = int.Parse(Console.ReadLine());
            double[,] mat = new double[x, x];
            double maior = 0;
            double media = 0;

            for(int i = 0; i < x; i++)
            {
                string[] value = Console.ReadLine().Split(" ");
                for (int j = 0; j < x; j++)
                {
                    mat[i, j] = int.Parse(value[j]);/* aqui estamos recebendo o valor de "value" que era string e estamos convertendo para int para depois inserir no mat[]*/
                    if (mat[i,j] > maior)
                    {
                        maior = mat[i, j];
                    }

                    media += mat[i, j];
                }
            }

            double mediaf = media / (x * 2);
            Console.Write("O maior número foi: " + maior + "\n");
            Console.Write("A média final foi: " + mediaf);
        }
    }
}
