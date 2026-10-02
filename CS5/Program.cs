using System;
// Espacio de nombres
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unidad 1:Estructuras de control II
            // Unidad 2: Funciones II
            // Sesión 12: Instrucciones while 30092026
            // Inicialización;
            // while(espresión)
            // {
            //        bloque de instrucciones
            //        iterador;
            // }
            // Iterar: repetir
            // Ejemplo !: ciclo ascendente (rango: 1-3)
            // m; variable de control
            int m = 1; // Inicialización
            while (m <= 3) // Expresión
            {
                // Bloque de instrucciones
                Console.WriteLine($"m: {m}");
                m += 1; // Iterador
            }
            // Ejercitación
            // 1. Definir un ciclo para imprimir tu nombre 5 veces.
            // Nota: Para la expresión, utilizar el operador <.
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine($"Tu nombre: Patricio");
                n += 1; // Iterador 
            }
            // b. Ciclo descendente
            int d = 3
            while (d >= 1)
            {
                Console.WriteLine($"d:{d}");
                d -= 1;
            }
            // C. Incrementos
            // Secuencia: 3 6 9 12 15 18
            int i = 3;
            while (i <= 18)
            {
                Console.WriteLine($"i:{1}");
                i += 3;
            }
            // d. Decrementos
            // Ejercitación
            // 1. Definir un ciclo para imprimir "331" 8 veces.
            // Nota: para la solución, definir un ciclo descendente con decrementos de unidades
            
            }
            
            /*
         Actividadd 1: Ciclo infinito

        1. Definir un ciclo infinito ascendente.
        2. Definir un ciclo infinito descendente.

        NOTA: Utilizar el operador de diferencia
         */

        // Ascendente

        int it1 = 1;

            while (it1 > 0) {
                Console.WriteLine(it1);
                it1++;
            }

            // Descendente

            int it2 = 99;

            while (it2 != 100) {
                Console.WriteLine(it2);
                it2--;
            }
        }
    }
}

