using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5) Se ingresan DNI y nota de un parcial de los alumnos de un curso. El ingreso de datos
            //   finaliza con un DNI negativo.Se sabe que como máximo pueden presentarse a rendir 60
            //   alumnos.Mostrar:
            //   a) Listado alumnos con su correspondiente DNI y la nota obtenida(en forma de listado)
            //   b) La máxima nota obtenida y el DNI de los alumnos que la obtuvieron.

            #region
            //int[] dni = new int[3];
            //int[] nota = new int[3];

            //int mayorNota = 0;
            //int dniMayorNota = 0;
            //int i = 0;

            //dni[i] = int.Parse(Console.ReadLine());
            //nota[i] = int.Parse(Console.ReadLine());

            //for (int i = 0; i < dni.Length; i++)
            //{
            //    if (nota[i] > mayorNota)
            //    {
            //        mayorNota = nota[i];
            //        dniMayorNota = dni[i];
            //    }
            //}

            //Console.WriteLine("La mayor nota es " + mayorNota + " y pertenece al alumno con el DNI: " + dniMayorNota);

            //for (int j = 0; j < dni.Length; j++)
            //{
            //    Console.WriteLine(dni[j]);
            //    Console.WriteLine(nota[j]);
            //}
            #endregion

            List<int> dni = new List<int>();
            List<int> nota = new List<int>();
            int dniComprobar = 0;


            Console.WriteLine("Ingrese el dni del alumno: ");
            dniComprobar = int.Parse(Console.ReadLine());


            while (dniComprobar > 0)
            {
                dni.Add(dniComprobar);

                Console.WriteLine("Ingrese la nota del alumno: ");
                nota.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Ingrese el dni del alumno: ");
                dniComprobar = (int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < dni.Count; i++)
            {
                Console.WriteLine("DNI: " + dni[i] + " Alumno: " + nota[i]);
            }

            Console.WriteLine("La nota maxima es: " + nota.Max());

            int posicion = nota.IndexOf(nota.Max());
                       
            Console.WriteLine("Pertenece al alumno: " + dni[posicion]);
        }
    }
}
