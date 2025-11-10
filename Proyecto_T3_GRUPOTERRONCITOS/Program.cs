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
                                Registrar.regilibro();
                                Console.SetCursorPosition(10, 18);
                                Console.Write("Presione cualquier tecla para volver al menú");
                                Console.ReadKey();
                                break;
                        }
                        break;

                    case 1:
                        break;
                    case 2:
                        int opcRepor = Registrar.ReportesMenu();
                        switch (opcRepor) 
                        {
                            case 0:
                                Registrar.docentes();
                                break;
                            case 1:
                                Registrar.alumnos();
                                break;
                            case 2:
                                Registrar.cursos();
                                break;
                            case 3:
                                return;
                        }
                        break;
                    case 3:

                        break;
                }

            } while (opcion != 3);
        }
    }
}
