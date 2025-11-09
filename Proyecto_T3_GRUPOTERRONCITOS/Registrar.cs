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
        private string[] nombreDocente = new string[0];
        private int[] DNI_DOCENTE = new int[0];
        private string nombre_DO;
        private string DNI_DO;

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


        public void regiDocente()
        {
            Console.WriteLine("REGISTRO DE DOCENTE");
            Console.Write("Ingrese el nombre del docente: ");
            nombre_DO = Console.ReadLine();

            bool dniValido = false;

            do
            {
                Console.Write("Ingrese su DNI: ");
                DNI_DO = Console.ReadLine().Trim();

                if (DNI_DO.Length == 8 && int.TryParse(DNI_DO, out _))
                {
                    dniValido = true;
                    Console.WriteLine("DNI válido.");

                    bool existeDNI = false;

                    for (int i = 0; DNI_DOCENTE.Length; i++)
                    {
                        if (DNI_DOCENTE[i] == DNI_DO)

                        {
                            existeDNI = true;
                            break;
                        }
                    }

                    if (existeDNI == true)
                    {
                        Console.WriteLine("El DNI ya existe. Intente con otro");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("¡ERROR! El DNI debe tener exactamente 8 números.");
                }

            } while (!dniValido);
        }
    }
}
