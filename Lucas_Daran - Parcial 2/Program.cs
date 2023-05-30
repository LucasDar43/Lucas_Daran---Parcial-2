using Lucas_Daran___Parcial_2;

namespace parcial2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Enteros enteros = new Enteros();

            Console.WriteLine("----Menu----");
            Console.WriteLine("1. Agregar Elementos");
            Console.WriteLine("2. Mostrar Arreglo");
            Console.WriteLine("3. Mostrar Cantidad de Elementos del Arreglo");
            Console.WriteLine("4. Busqueda por Indice");
            Console.WriteLine("5. Editar Arreglo");
            Console.WriteLine("6. Estado del Arreglo");
            Console.WriteLine("7. Eliminar todos los elementos del Arreglo");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: 
            }


            //agregar
            enteros.Add(10);
            enteros.Add(20);
            enteros.Add(30);
            //

            //mostrar array
            enteros.ImprimirArreglo();
            //

            //busqueda index
            int elemento = enteros.GetAt(1);
            Console.WriteLine("Elemento en la posición 1: " + elemento);
            //


            enteros.SetAt(40, 2);
            enteros.ImprimirArreglo();

            int cantidadElementos = enteros.GetLength();
            Console.WriteLine("Cantidad de elementos: " + cantidadElementos);

            bool vacio = enteros.IsEmpty();
            Console.WriteLine("¿El arreglo está vacío?: " + vacio);

            enteros.RemoveAll();
            enteros.ImprimirArreglo();

            vacio = enteros.IsEmpty();
            Console.WriteLine("¿El arreglo está vacío?: " + vacio);

        }
    }
}
