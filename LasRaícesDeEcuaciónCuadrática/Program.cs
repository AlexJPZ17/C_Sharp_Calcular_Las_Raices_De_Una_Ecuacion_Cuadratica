using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LasRaícesDeEcuaciónCuadrática
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos 9 variables de tipo double
            double a, b, c, d, e, f, g, h, opcion;
            //Inicial izamos las variables d,e,f,g,h, opción
            d = 0;
            e = 0;
            f = 0;
            g = 0;
            h = 0;
            opcion = 0;
            //Instrucción do while
            do
            {
                //Mensajes para ingresar el valor desde la consola
                Console.Write("Escribe el coeficiente a: ");
                //Método que convierte en un tipo double el valor que se ingrese por la consola 
                a = Double.Parse(Console.ReadLine());
                //Mensajes para ingresar el valor desde la consola
                Console.Write("Escribe el coeficiente b: ");
                //Método que convierte en un tipo double el valor que se ingrese por la consola 
                b = Double.Parse(Console.ReadLine());
                //Mensajes para ingresar el valor desde la consola
                Console.Write("Escribe el coeficiente c: ");
                //Método que convierte en un tipo double el valor que se ingrese por la consola 
                c = Double.Parse(Console.ReadLine());
                /* Multiplicaciones de las variables a, c, b y el resultado de las dos multiplicaciones 
                    se restarán y el resultado se almacena en la variable d */
                d = ((b * b) - (4 * a * c));
                /* Multiplicación de la variables a 
                    y el resultado se almacena en la variable e */
                e = ((2) * (a));
                //Condición que evalúa la variable e si es menor o igual a 0
                if (e <= 0)
                {
                    /* Mensajes que despliega un mensaje con la opción si y no si el
                         resultado es negativo */
                    Console.Write(" El coeficiente a es negativo, no se puede dividir Repetir 1-Si 2-No:");
                    /* Método que convierte en un tipo duoble el valor que se ingrese por la consola
                       ya que el mensaje nos pide ingresar el valor de 1 o el valor de 2 y el valor
                        ingresado se almacena en la variable opción */
                    opcion = Double.Parse(Console.ReadLine());
                }
                else
                {
                    //Condición que evalúa la variable d si es menor o igual a 0
                    if (d <= 0)
                    {
                        Console.Write("No existe raiz de un  numero negativo, Repetir 1-Si 2-No:");
                        opcion = Double.Parse(Console.ReadLine());
                    }
                    else
                    {
                        /* Método para sacar la raíz cuadrada del dato almacenado en 
                            la variable d y el resultado se almacena en la variable h */
                        h = Math.Sqrt(d);
                        //a las variables b,e,h funciones de suma resta multiplicación y división 
                        f = (((-b) + (h)) / e);
                        g = (((-b) - (h)) / e);
                        /*Mensajes que muestran el resultado que esta almacenados en la
                           variable f, g */
                        Console.Write("La raiz x1_:" + f + "\n");
                        Console.Write("La raiz x2_:" + g +"\n");
                        Console.Write("Repetir 1-Si 2-No:");
                        opcion = Double.Parse(Console.ReadLine());
                    }
                }
            } while (opcion == 1);
        }
    }
}
   