using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T3_GRUPOTERRONCITOS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion;

            do
            {
                opcion = menú.OpcionMenu();
                switch (opcion) 
                {
                    case 0:
                        int opcRegi = Registrar.SelecRegistrar();
                        switch (opcRegi) 
                        {
                            case 0:
                                Registrar.regiDocente();
                                Console.SetCursorPosition(10, 18);
                                Console.Write("Presione cualquier tecla para volver al menú");
                                Console.ReadKey();

                                break;
                            case 1:
                                Registrar.regiAlummnos();
                                Console.SetCursorPosition(10, 18);
                                Console.Write("Presione cualquier tecla para volver al menú");
                                Console.ReadKey();
                                break;
                            case 2:
                                Registrar.regiCurso();
                                Console.SetCursorPosition(10, 20);
                                Console.Write("Presione cualquier tecla para volver al menú");
                                Console.ReadKey();
                                break;
                        }
                        break;

                    case 1:
                        Console.SetCursorPosition(15, 11);
                        Console.WriteLine("\nCompre la version premium para aceder a esta parte del menú");
                        Console.SetCursorPosition(8, 18);
                        Console.Write("Presione cualquier tecla para volver al menú");
                        Console.ReadKey();
                        break;

                    case 2:
                        int opcregi = Registrar.ReportesMenu();
                        switch (opcregi) 
                        {
                            case 0:
                                Registrar.docentes();
                                Console.SetCursorPosition(10, 18);
                                Console.Write("Presione cualquier tecla para volver al menú");
                                Console.ReadKey();
                                break;
                            case 1:
                                Registrar.alumnos();
                                Console.SetCursorPosition(10, 18);
                                Console.Write("Presione cualquier tecla para volver al menú");
                                Console.ReadKey();
                                break;
                            case 2:
                                Registrar.cursos();
                                Console.SetCursorPosition(10, 18);
                                Console.Write("Presione cualquier tecla para volver al menú");
                                Console.ReadKey();
                                break;
                        }

                        break;
                    case 3:
                        Console.SetCursorPosition(15, 10);
                        Console.WriteLine("Usted ah saldio del programa");
                        break;
                }

            } while (opcion != 3);
        }
    }
}
