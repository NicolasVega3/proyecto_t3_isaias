using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_GRUPOTERRONCITOS
{
    internal class menú
    {
        public static int OpcionMenu()
        {
            ConsoleKey tecla;
            string[] arregloMenu = { "REGISTRAR", "ASISTENCIA", "REPORTES", "SALIDA" };

            int index = 0;

            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("           SISTEMA DE GESTIÓN DE ASISTENCIA            ");
                Console.WriteLine("-------------------------------------------------------");
                Console.ResetColor();

                for (int i = 0; i < arregloMenu.Length; i++)
                {
                    if (i == index)
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


                ConsoleKeyInfo info = Console.ReadKey(true);
                tecla = info.Key;

                if (tecla == ConsoleKey.RightArrow)
                {
                    index++;
                    if (index > arregloMenu.Length - 1)
                    {
                        index = 0;
                    }
                }
                else if (tecla == ConsoleKey.LeftArrow)
                {
                    index--;
                    if (index < 0)
                    {
                        index = arregloMenu.Length - 1;
                    }
                }
            } while (tecla != ConsoleKey.Enter);
            return index;
        }
    }
}
