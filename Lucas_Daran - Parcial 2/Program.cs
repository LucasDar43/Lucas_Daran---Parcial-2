using Lucas_Daran___Parcial_2;

namespace parcial2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Enteros enteros = new Enteros();

            bool volver = true;
            do
            {
                Console.WriteLine("----Menu----");
                Console.WriteLine("1. Agregar Elementos");
                Console.WriteLine("2. Mostrar Arreglo");
                Console.WriteLine("3. Mostrar Cantidad de Elementos del Arreglo");
                Console.WriteLine("4. Busqueda por Indice");
                Console.WriteLine("5. Editar Arreglo");
                Console.WriteLine("6. Estado del Arreglo");
                Console.WriteLine("7. Eliminar todos los elementos del Arreglo");
                Console.WriteLine("0. Salir");

                int opcion = int.Parse(Console.ReadLine());
            
                bool vacio = enteros.IsEmpty();

                bool continuar = true;

                while (continuar)
                {
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Ingrese la cantidad de elementos para añadir");
                                int cantElementosIngr = int.Parse(Console.ReadLine());

                                for (int i = 0; i < cantElementosIngr; i++)
                                {
                                    Console.WriteLine("Ingrese Elemento N°: " + (i));
                                    int ingresoElemento = int.Parse(Console.ReadLine());
                                    enteros.Add(ingresoElemento);
                                }
                                Console.WriteLine("~Los Elementos se añadieron correctamente~");
                                Cierre();
                                continuar = false;
                                break;

                            case 2:

                                if (vacio)  //enteros.CantidadElementos == 0
                                {
                                    Console.WriteLine("El arreglo no tiene elementos");
                                }
                                else
                                {
                                    enteros.ImprimirArreglo();
                                }
                                Cierre();
                                continuar = false;
                                break;

                            case 3:

                                int cantidadElementos = enteros.GetLength();
                                Console.WriteLine("Cantidad de elementos: " + cantidadElementos);
                                Cierre();
                                continuar = false;
                                break;

                            case 4:

                                Console.WriteLine("Ingrese el indice a buscar");
                                int indexBuscado = int.Parse(Console.ReadLine());
                                int buscarElemento = enteros.GetAt(indexBuscado);
                                Console.WriteLine($"Elemento en la posición {indexBuscado}: " + buscarElemento);
                                Cierre();
                                continuar = false;
                                break;

                            case 5:

                                if (enteros.CantidadElementos == 0)
                                {
                                    Console.WriteLine("Imposible editar porque el arreglo esta vacio");                           
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese -Indice a Editar-");
                                    int indiceEdit = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese -Elemento nuevo-");
                                    int elementoEdit = int.Parse(Console.ReadLine());

                                    int cantElementos = enteros.GetLength();
                                    if (indiceEdit > cantElementos)
                                    {
                                        Console.WriteLine("Error. Indice incorrecto");
                                    }
                                    else
                                    {
                                        enteros.SetAt(elementoEdit, indiceEdit);
                                        Console.WriteLine("~El arreglo se edito correctamente~");
                                    }
                                }
                                Cierre();
                                continuar = false;
                                break;

                            case 6:
                            
                                Console.WriteLine("¿El arreglo está vacío?: " + vacio);
                                Cierre();
                                continuar = false;
                                break;

                            case 7:
                                Console.WriteLine("Estas seguro de borrar todos los elementos del arreglo? si/no");
                                string resp = Console.ReadLine();

                                if (resp != "si" && resp != "no")
                                {
                                    Console.WriteLine("Error de tipeo");
                                }
                                else if (resp == "no")
                                {
                                    Console.WriteLine("Borrado Incompleto. Presione -Enter- para volver al menu principal");
                                    continuar = false;
                                }
                                else
                                {
                                    Console.WriteLine("~Los elementos se eliminaron correctamente~");
                                    enteros.RemoveAll();
                                }
                                Cierre();
                                continuar = false;
                                break;

                        case 0:
                            Environment.Exit(1);
                            break;

                        default:
                            Console.WriteLine("Error. Vuelva a Ingresar");
                            Cierre();
                            continuar = false;
                            break;
                        }        
                }
            } while (volver = true);
        }

        private static void Cierre()
        { 
            Console.ReadKey();
            Console.Clear();            
        }
            

    }
}
