using System;

namespace Validacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random aleatorio = new Random();
            int a = 0, b = 0, robot = 0;
            

            for (int turno = 0; turno < 3; turno++)
            {
                Console.WriteLine("Arriba las manos sospecho que usted es un robot");
                Console.WriteLine("ingrese la respuesta de la operacion que ve en pantalla para comprobar");

                a = aleatorio.Next(1, 11);
                b = aleatorio.Next(1, 11);
                Console.WriteLine(" " + a + " +  " + b);
                robot = int.Parse (Console.ReadLine());

                if (robot != a+b)
                {
                    Console.WriteLine("Huy mijo como que si es un robot vuelva a intentarlo");
                }
                else 
                {
                    Console.WriteLine("Todo este tiempo confie en usted cof...");
                    string pajarito =
                      "\n  ^ ^" +
                      "\n (O,O)" +
                      "\n (   )" +
                      "\n  T T";
                    Console.WriteLine(pajarito);
                    break;
                }
                
            }


        }
    }
}
