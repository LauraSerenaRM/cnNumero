using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnNumero
{/// <summary>
///  Nombre: Laura Serena Rivera Mejía
///  Fecha: 24-02-2023
///  Descripción: Este programa evalúa tres números enteros e imprime por mensaje el mayor y el menor de ellos.
/// </summary>
    internal class ClsNumero
    {

        //Declaración de variables
        int Numero1, Numero2, Numero3;
        static void Main(string[] args)
        {   
            //Se crea un objeto de la Clase Numero.
            ClsNumero oNumero = new ClsNumero();
            //Se llaman los métodos a partir del objeto numero
            oNumero.SolicitarNumero();
            oNumero.NumeroMayor();
            oNumero.NumeroMenor();
            //Instrucción de espera al final de toda la ejecución.
            Console.ReadLine();
        }
        //Método 1
        public void SolicitarNumero()
        {
            Console.WriteLine("Ingresar el número 1");
            Numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2");
            Numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el número 3");
            Numero3 = int.Parse(Console.ReadLine());


        }
        //Método 2
        public void NumeroMayor()
        {

            //Ciclo logico 1
            if (Numero1 > Numero2 & Numero1 > Numero3)
            {
                Console.WriteLine("El número mayor es " + Numero1);
            }
            else if (Numero2 > Numero1 & Numero2 > Numero3)
            {
                Console.WriteLine("El número mayor es " + Numero2);
            }
            else if (Numero3 > Numero1 & Numero3 > Numero2)
            {
                Console.WriteLine("El número mayor es " + Numero3);
            }

        }
        //Método 3
        public void NumeroMenor()
        {

            //Ciclo logico 2
            if (Numero1 < Numero2 & Numero1 < Numero3)
            {
                Console.WriteLine("El número menor es " + Numero1);
            }
            else if (Numero2 < Numero1 & Numero2 < Numero3)
            {
                Console.WriteLine("El número menor es " + Numero2);
            }
            else if (Numero3 < Numero1 & Numero3 < Numero2)
            {
                Console.WriteLine("El número menor es " + Numero3);
            }



        }

    }
}
