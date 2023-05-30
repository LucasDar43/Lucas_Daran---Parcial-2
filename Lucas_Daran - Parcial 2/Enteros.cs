using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas_Daran___Parcial_2
{
    internal class Enteros
    {

        private const int MaxElementos = 100;
        private int[] arreglo;
        private int cantidadElementos;

        public Enteros()
        {
            arreglo = new int[MaxElementos];
            cantidadElementos = 0;
        }

        public int CantidadElementos
        {
            get { return cantidadElementos; }
        }

        public int Add(int elemento)
        {
            if (cantidadElementos < MaxElementos)
            {
                arreglo[cantidadElementos] = elemento;
                cantidadElementos++;
                return cantidadElementos - 1;
            }
            else
            {
                Console.WriteLine("El arreglo está lleno. No se puede agregar más elementos.");
                return -1;
            }
        }

        public int GetAt(int index)
        {
            if (index >= 0 && index < cantidadElementos)
            {
                return arreglo[index];
            }
            else
            {
                Console.WriteLine("Índice fuera de rango. No se puede obtener el elemento.");
                return -1; // Valor sentinela para indicar un error
            }
        }

        public void SetAt(int elemento, int index)
        {
            if (index >= 0 && index < cantidadElementos)
            {
                arreglo[index] = elemento;
            }
            else
            {
                Console.WriteLine("Índice fuera de rango. No se puede establecer el elemento.");
            }
        }

        public void RemoveAll()
        {
            cantidadElementos = 0;
        }

        public int GetLength()
        {
            return cantidadElementos;
        }

        public bool IsEmpty()
        {
            return cantidadElementos == 0;
        }

        public void ImprimirArreglo()
        {
            Console.WriteLine("Elementos en el arreglo:");
            for (int i = 0; i < cantidadElementos; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
        }

    }
}
