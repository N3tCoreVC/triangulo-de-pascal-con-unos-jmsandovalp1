using System;

namespace triangulo_de_pascal_con_unos_jmsandovalp1

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World. Dame tu nombre: ");
            String lineaescrita = Console.ReadLine();
            Console.WriteLine("Tu nombre es: " +lineaescrita);

            Console.Write("Dame un numero: ");
            String numeroi = Console.ReadLine();
            int num1;
            int fact=1;
            if (int.TryParse(numeroi, out num1))
            {
                for (int j=1; j<=num1;j++)
                {
                    fact = fact * j;
                }
                Console.WriteLine("El numero factorial de " + numeroi + " es " + fact);
            }
            else
            {
                Console.WriteLine("Escribe un numero valido");
            }
            //int num1 = Int32.Parse(numeroi);

            //Crear una funcion suma que reiba un entero y calcula la suma de los numeros pares del 1 al entero.
            //Utilizarla en el programa principal
            //Ejemplo suma(4) Resultado 6
            Console.Write("Dame un numero: ");
            String nume = Console.ReadLine();
            int nume1;
            
            if (int.TryParse(nume, out nume1))
            {
                Console.WriteLine("La suma de los numeros pares es: " + Suma(nume1));
            }
            else
            {
                Console.WriteLine("Escribe un numero valido");
            }

            Console.Write("Dame el tamaño de la piramide: ");
            String numep = Console.ReadLine();
            int numep1;
            
            if (int.TryParse(numep, out numep1))
            {
                 for (int nivel=1; nivel<=numep1+1;nivel++)
                {
                    //Imprimir los espacios de la izquierda
                    for (int esp=1;esp <= numep1+1-nivel; esp++)
                    {
                        Console.Write(" ");
                    }
                    
                    
                    for (int r=1; r <= 2*nivel-1; r++)
                    {
                        if (r%2 == 0)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    }

                    
                    
                    Console.WriteLine(" ");
                    
                    //Console.WriteLine(" ");
                }
            }
            else
            {
                Console.WriteLine("Escribe un numero valido");
            }

           
            
/* 

            for (int i =1; i<10; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i + "es un numero par");
                }
                else
                {
                    Console.WriteLine(i + " es un numero impar");
                }
            }
            */
        }
         private static int Suma(int valor1)
        {
          int suma=0;
          for (int j=1; j<=valor1;j++)
            {
                    if (j%2 == 0)
                {
                    suma = suma + j;
                }
            }

          return suma;      
        }
    }
    
}