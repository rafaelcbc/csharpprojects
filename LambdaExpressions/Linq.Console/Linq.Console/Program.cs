﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 10, 50, 10, 22, 32, 44 };
            int[] B = { 15, 10, 22, 5, 7, 9, 10 };

            var AB = A.Concat(B);

            // 1) Imprimir na tela os itens ordenados
            Console.Write("AB Ordenados: ");
            foreach (int i in AB)
            {
                Console.Write(i + " ");
            }
            /// Quebra de Linha
            Console.WriteLine();
            //------------------------------------


            // 2) Imprimir a Interssessão
            var ABInter = A.Intersect(B);
            Console.Write("A Intersessão B: ");
            foreach(int i in ABInter)
            {
                Console.Write(i + " ");
            }
            /// Quebra de Linha
            Console.WriteLine();
            //------------------------------------


            // 3) Imprimir a União porém sem repetir nenhum numero
            var ABUnion = A.Union(B);
            Console.Write("A União B: ");
            foreach(int i in ABUnion)
            {
                Console.Write(i + " ");
            }
            /// Quebra de Linha
            Console.WriteLine();
            //------------------------------------


            // 4) Imprima o maior elemento
            var ABMaior = A.Concat(B).Max();
            Console.Write("AB Maior: " + ABMaior);
            /// Quebra de Linha
            Console.WriteLine();
            //------------------------------------

            
            // 5) Imprima o menor elemento
            var ABMenor = A.Concat(B).Min();
            Console.Write("AB Menor: " + ABMenor);
            /// Quebra de Linha
            Console.WriteLine();
            //------------------------------------

            
            // 6) Imprima os elementos pares
            var ABPar = AB.Where(x => x % 2 == 0);
            Console.Write("AB Pares: ");
            foreach (int i in ABPar)
            {
                Console.Write(i + " ");
            }
            /// Quebra de Linha
            Console.WriteLine();
            //------------------------------------


            // 7) Imprima a média
            var ABMedia = AB.Average();
            Console.Write("AB Média: " + ABMedia);
            /// Quebra de Linha
            Console.WriteLine();
            //------------------------------------


            // 8) Imprima os elementos que pertencem apenas a uma lista
            var ABDist = AB.Distinct();
            Console.Write("AB Distintos: ");
            foreach (int i in ABDist)
            {
                Console.Write(i + " ");
            }
            /// Quebra de Linha
            Console.WriteLine();
            //------------------------------------


            // 9) Check com Any() se tem algum numero impar
            var TemImpar = AB.Any(x => x % 2 == 1);
            Console.Write("Existe algum número ímpar? " + TemImpar);
            /// Quebra de Linha
            Console.WriteLine();
            //------------------------------------


            //Pause do Sistema
            Console.ReadKey();
        }
    }
}
