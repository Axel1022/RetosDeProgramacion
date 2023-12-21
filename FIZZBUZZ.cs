/*
 * Escribe un programa que muestre por consola (con un print) los
 * números de 1 a 100 (ambos incluidos y con un salto de línea entre
 * cada impresión), sustituyendo los siguientes:
 * - Múltiplos de 3 por la palabra "fizz".
 * - Múltiplos de 5 por la palabra "buzz".
 * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
 */
 Console.Clear();
 foreach (var num in Enumerable.Range(1, 100))
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine($"{num}: fizzbuzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine($"{num}: fizz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine($"{num}: buzz");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
