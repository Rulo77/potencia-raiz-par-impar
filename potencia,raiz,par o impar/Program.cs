using System;

namespace potencia_raiz_par_o_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            double num;
            do
            {
                Console.WriteLine("seleccione una de las siguiente opciones: ");
                Console.WriteLine("1. elevar potencia");
                Console.WriteLine("2. extraer raiz cuadrada");
                Console.WriteLine("3. verificar si un numero es par o impar");
                Console.WriteLine("4. salir del programa");
                opc = int.Parse(Console.ReadLine());

                if (opc != 4)
                {
                    Console.WriteLine("introduce un numero");
                    num = double.Parse(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            num = Math.Pow(num, 2);
                            Console.WriteLine("la potencia es: " + num);
                            break;
                        case 2:
                            num = Math.Sqrt(num);
                            Console.WriteLine("la raiz es: " + num);
                            break;
                        case 3:
                            if (num % 2 == 0)
                            {
                                Console.WriteLine("el numero es par");
                            }
                            else
                            {
                                Console.WriteLine("el numero es impar");
                            }
                            break;
                        default:
                            Console.WriteLine("opcion incorrecta");
                            break;
                    }
                }
                Console.ReadKey();
                Console.Clear();

            } while (opc != 4);
            Console.WriteLine("saliendo del programa................");

            Console.ReadKey();
        }
    }
    
}
