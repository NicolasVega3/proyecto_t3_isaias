using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_GRUPOTERRONCITOS
{
    public class Registrar
    {
        public static string[] nombreDocente = new string[0];
        public static int[] DNI_DOCENTE = new int[0];
        public static string nombre_DO;
        public static int DNI_DO;

        public static int SelecRegistrar() 
        {
            ConsoleKey tecla;
            string[] opciones = {"DOCENTE", "ESTUDIANTE", "CURSO", "VOLVER" };
            string[] arregloMenu = { "REGISTRAR", "ASISTENCIA", "REPORTES", "SALIDA" };
            int index = 0;

            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("           SISTEMA DE GESTIÓN DE ASISTENCIA           ");
                Console.WriteLine("------------------------------------------------------");
                Console.ResetColor();
                Console.WriteLine();

                for (int i = 0; i < arregloMenu.Length; i++) 
                {
                    if (i == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("    " + arregloMenu[i] + "    ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(arregloMenu[i] + "     ");
                    }
                }
                for (int i = 0; i < opciones.Length; i++) 
                {
                    if (i == index)
                    {
                        
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"{opciones[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"{opciones[i]}");
                    }
                }
                ConsoleKeyInfo info = Console.ReadKey(true);
                tecla = info.Key;

                if (tecla == ConsoleKey.DownArrow)
                {
                    index++;
                    if (index >= opciones.Length)
                        index = 0;
                }
                else if (tecla == ConsoleKey.UpArrow) 
                {
                    index--;
                    if (index < 0)
                        index = opciones.Length - 1;
                }

            } while (tecla != ConsoleKey.Enter);
            return index;
        }


        public static void regiDocente()
        {
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("REGISTRO DE DOCENTE");
            Console.SetCursorPosition(10, 11);
            Console.Write("Nombre: ");
            nombre_DO = Console.ReadLine();

            do
            {
                Console.SetCursorPosition(10, 12);
                Console.Write("DNI: ");
                DNI_DO = Convert.ToInt32(Console.ReadLine());
                if (!(DNI_DO < 100000000 && DNI_DO > 9999999))
                {
                    Console.WriteLine("DNI debe tener 8 dígitos");
                    Console.WriteLine("Presione cualquier tecla para volver a intentarlo");
                    Console.ReadKey();
                }
                else
                    break;
            } while (true);

            bool existeDNIDO = false;

            for (int i = 0; i < DNI_DOCENTE.Length; i++)
            {
                if (DNI_DOCENTE[i] == DNI_DO)
                {
                    existeDNIDO = true;
                    break;
                }
            }

            if (existeDNIDO == true)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("El DNI ya existe. Intente con otro");
            }

            Array.Resize(ref DNI_DOCENTE, DNI_DOCENTE.Length + 1);
            Array.Resize(ref nombreDocente, nombreDocente.Length + 1);

            DNI_DOCENTE[DNI_DOCENTE.Length - 1] = DNI_DO;
            nombreDocente[nombreDocente.Length - 1] = nombre_DO;
        }
    }
}
