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
        //Arreglos y def de variables de docentes
        private static string[] nombreDocente = new string[0];
        private static int[] DNI_DOCENTE = new int[0];
        private static string nombre_DO;
        private static int DNI_DO = 0;

        //Arreglos y def de variables de alumnos
        private static string[] nombreAlumno = new string[0];
        private static int[] DNI_Alumno = new int[0];
        private static string nombre_Al;
        private static int DNI_Al = 0;

        //Arreglos y def de variables de cursos
        private static string[] nomCurso = new string[0];
        private static double[] precioCurso = new double[0];
        private static string[] codigoCurso = new string[0];
        private static string nom_Curso;
        private static double newPrecio;
        private static string codigo_Curso;

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
                    Console.SetCursorPosition(2, 5+i);
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
            Console.Write("NOMBRE DOCENTE: ");
            string nombre_DO = Console.ReadLine();

            bool dniValido = false;

            while (!dniValido)
            {
                Console.Write("\t  DNI DOCENTE: ");
                string inputDNI = Console.ReadLine();

                if (int.TryParse(inputDNI, out DNI_DO))
                {
                    if (DNI_DO < 10000000 || DNI_DO > 99999999)
                    {
                        Console.WriteLine("\t  El DNI debe tener exactamente 8 dígitos");
                        Console.WriteLine("\t  Presione cualquier tecla para reintentar...");
                        Console.ReadKey();
                        continue;
                    }

                    bool existeDNI = false;
                    for (int i = 0; i < DNI_DOCENTE.Length; i++)
                    {
                        if (DNI_DOCENTE[i] == DNI_DO)
                        {
                            existeDNI = true;
                            break;
                        }
                    }

                    if (existeDNI)
                    {
                        Console.WriteLine("\t  El DNI ya existe. Intente con otro");
                        Console.WriteLine("\t  Presione cualquier tecla para reintentar...");
                        Console.ReadKey();
                        continue;
                    }

                    dniValido = true;
                }
                else
                {
                    Console.WriteLine("\t  Ingrese un número válido");
                    Console.WriteLine("\t  Presione cualquier tecla para reintentar...");
                    Console.ReadKey();
                }
            }

            Array.Resize(ref DNI_DOCENTE, DNI_DOCENTE.Length + 1);
            Array.Resize(ref nombreDocente, nombreDocente.Length + 1);

            DNI_DOCENTE[DNI_DOCENTE.Length - 1] = DNI_DO;
            nombreDocente[nombreDocente.Length - 1] = nombre_DO;

            Console.SetCursorPosition(10, 16);
            Console.WriteLine("Se guardó correctamente el nuevo docente...");
        }


        public static void regiAlummnos()
        {
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("REGISTRO DE ALUMNOS");
            Console.SetCursorPosition(10, 11);
            Console.Write("NOMBRE ALUMNO: ");
            nombre_Al = Console.ReadLine();

            bool dniValido = false;

            while (!dniValido)
            {
                Console.Write("\t  DNI ALUMNO: ");
                string inputDNI = Console.ReadLine();

                if (int.TryParse(inputDNI, out DNI_Al))
                {
                    if (DNI_Al < 10000000 || DNI_Al > 99999999)
                    {
                        Console.WriteLine("\t  El DNI debe tener exactamente 8 dígitos");
                        Console.WriteLine("\t  Presione cualquier tecla para reintentar...");
                        Console.ReadKey();
                        continue;
                    }

                    bool existeDNI = false;
                    for (int i = 0; i < DNI_Alumno.Length; i++)
                    {
                        if (DNI_Alumno[i] == DNI_Al)
                        {
                            existeDNI = true;
                            break;
                        }
                    }

                    if (existeDNI)
                    {
                        Console.WriteLine("\t  El DNI ya existe. Intente con otro");
                        Console.WriteLine("\t  Presione cualquier tecla para reintentar...");
                        Console.ReadKey();
                        continue;
                    }

                    dniValido = true;
                }
                else
                {
                    Console.WriteLine("\t  Ingrese un número válido");
                    Console.WriteLine("\t  Presione cualquier tecla para reintentar...");
                    Console.ReadKey();
                }
            }

            Array.Resize(ref DNI_Alumno, DNI_Alumno.Length + 1);
            Array.Resize(ref nombreAlumno, nombreAlumno.Length + 1);

            nombreAlumno[nombreAlumno.Length - 1] = nombre_Al;
            DNI_Alumno[DNI_Alumno.Length - 1] = DNI_Al;

            Console.WriteLine("\t  ALUMNO CORRECTAMENTE REGISTRADO");
        }


        public static void regiCurso()
        {
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("REGISTRO DE CURSO");

            string codigo = "";
            string nom_Curso = "";
            double precio = 0;

            bool codigoValido = false;
            while (!codigoValido)
            {
                Console.Write("\t  CODIGO: ");
                codigo = Console.ReadLine();

                if (codigo.Length != 6)
                {
                    Console.WriteLine("\t  El código debe tener 6 dígitos");
                    Console.ReadKey();
                    continue;
                }

                bool existeCodigo = false;
                for (int i = 0; i < codigoCurso.Length; i++)
                {
                    if (codigoCurso[i] == codigo)
                    {
                        existeCodigo = true;
                        break;
                    }
                }

                if (existeCodigo)
                {
                    Console.WriteLine("\t  El código ya existe. Ingrese uno diferente.");
                    Console.ReadKey();
                    continue;
                }

                codigoValido = true;
            }

            bool nombreValido = false;
            while (!nombreValido)
            {
                Console.Write("\t  CURSO: ");
                nom_Curso = Console.ReadLine();

                // Validar si está vacío
                if (nom_Curso == "")
                {
                    Console.WriteLine("\t  El nombre no puede estar vacío.");
                    Console.ReadKey();
                    continue;
                }

                bool existeNombre = false;
                for (int i = 0; i < nomCurso.Length; i++)
                {
                    if (nomCurso[i].ToLower() == nom_Curso.ToLower())
                    {
                        existeNombre = true;
                        break;
                    }
                }

                if (existeNombre)
                {
                    Console.WriteLine("\t  Ese curso ya existe. Ingrese otro nombre.");
                    Console.ReadKey();
                    continue;
                }

                nombreValido = true;
            }

            bool precioValido = false;
            while (!precioValido)
            {
                Console.Write("\t  PRECIO: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out precio) && precio >= 0)
                {
                    precioValido = true;
                }
                else
                {
                    Console.WriteLine("\t  Ingrese un precio válido.");
                    Console.ReadKey();
                }
            }
            Array.Resize(ref codigoCurso, codigoCurso.Length + 1);
            Array.Resize(ref nomCurso, nomCurso.Length + 1);
            Array.Resize(ref precioCurso, precioCurso.Length + 1);

            codigoCurso[codigoCurso.Length - 1] = codigo;
            nomCurso[nomCurso.Length - 1] = nom_Curso;
            precioCurso[precioCurso.Length - 1] = precio;

            Console.WriteLine("\t  Curso registrado correctamente.");
        }

        public static int ReportesMenu()
        {
            ConsoleKey tecla;
            string[] opciones = { "DOCENTE", "ESTUDIANTE", "CURSO", "VOLVER" };
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
                    if (i == 2)
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
                    Console.SetCursorPosition(29, 5 + i);
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

        public static void docentes() 
        {
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("DOCENTES:\n");
            if (nombreDocente.Length == 0)
            {
                Console.SetCursorPosition(12, 11);
                Console.WriteLine("No hay docentes registrados.\n");
            }
            else 
            {
                for (int i = 0; i < nombreDocente.Length; i++) 
                {
                    Console.SetCursorPosition(12, 11+i);
                    Console.WriteLine($"Nombre: {nombreDocente[i]}  |  DNI: {DNI_DOCENTE[i]}");
                }
                    
            }

        }

        public static void alumnos() 
        {
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("ESTUDIANTES:\n");
            if (nombreAlumno.Length == 0)
            {
                Console.SetCursorPosition(12, 11);
                Console.WriteLine("No hay estudiantes registrados.\n");
            }

            else 
            {
                for (int i = 0; i < nombreAlumno.Length; i++) 
                {
                    Console.SetCursorPosition(12, 11 + i);
                    Console.WriteLine($"Nombre: {nombreAlumno[i]}  |  DNI: {DNI_Alumno[i]}");
                }
                    
            }
                
        }

        public static void cursos() 
        {
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("\tCURSOS:\n");
            if (nomCurso.Length == 0)
            {
                Console.SetCursorPosition(12, 11);
                Console.WriteLine("No hay cursos registrados.\n");
            }
            else
            {
                for (int i = 0; i < nomCurso.Length; i++) 
                {
                    Console.SetCursorPosition(12, 11 + i);
                    Console.WriteLine($"Curso: {nomCurso[i]}  |  Codigo: {codigoCurso[i]}  |  Precio: S/.{precioCurso[i]}");
                }
                    
            }
        }
    }
}
