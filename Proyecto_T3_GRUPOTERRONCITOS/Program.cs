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
                                //Llamar al método para registrar docente
                                break;
                            case 1:
                                //Llamar al método para registrar estudiante
                                break;
                            case 2:
                                //Llamar al método para registrar curso
                                break;
                        }
                        break;
                    case 1:
                        
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                }

            } while (opcion != 3);
        }
    }
}
