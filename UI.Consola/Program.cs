using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Consola
{
    class Program
    {
        static void Main(string[] args)
        {         
                char confir = 'S';
                while (confir == 'S')
                {
                    Console.Clear();
                    Console.WriteLine("MENU");
                    Console.WriteLine("1– Usuarios \n2– Alumnos \n3– Especialidades \n4- Profesores  \n5- Planes y materias \n6- Comisiones" +
                        "\n7- Cursos \n8- Inscribir a curso \n9- Registro de notas \n10- Reporte de cursos \n11- Reporte de planes \n12- Salir");
                    int opc = Console.Read();
                    switch (opc)
                    {
                        case 1:
                            {
                                new Usuarios(new Business.Logic.UsuarioLogic()).Menu(); 
                                break;
                            }
                        case 2: 
                            {
                                //new Alumnos(new Business.Logic.AlumnoLogic()).Menu(); 
                                break;
                            }
                        case 3:
                        {
                            /* new Especialidades(new Business.Logic.EspecialidadLogic()).Menu(); */
                            break; 
                            }
                        case 4:
                            {
                               // new Profesores(new Business.Logic.ProfesorLogic()).Menu();
                                break;
                            }
                        case 5:
                            {
                                Console.Clear();
                                Console.WriteLine("1)Planes 2)Materias");
                                int a = Console.Read();
                                if (a==1) new Planes(new Business.Logic.PlanLogic()).Menu();
                               // else new Materias(new Business.Logic.MateriaLogic()).Menu();
                                break;
                            }
                        case 6:
                            {
                                //new Comisiones(new Business.Logic.ComisionLogic()).Menu();
                                break;
                            }
                        case 7:
                            {
                                //new Cursos(new Business.Logic.CursoLogic()).Menu();
                                break;
                            }
                        case 8:
                            {
                                // inscribir a curso
                                break;
                            }
                        case 9:
                            {
                                //registro de notas
                                break;
                            }
                        case 10:
                            {
                                //reporte de cursos
                                break;
                            }
                        case 11:
                            {
                                //reporte de planes
                                break;
                            }
                        case 12:
                            {
                                break;
                            }
                    }
                    Console.WriteLine("Desea continuar? S/N");
                    confir = char.Parse(Console.ReadLine());
                    confir = Char.ToUpper(confir);
                }
            
        }
    }
}
