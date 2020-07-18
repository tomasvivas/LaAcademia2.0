using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using Business.Entities;

namespace UI.Consola 
{
    public class Especialidades

    {
        private Business.Logic.EspecialidadLogic _EspecialidadNegocio;

        public Business.Logic.EspecialidadLogic EspecialidadNegocio
        {
            get { return _EspecialidadNegocio; }
            set { _EspecialidadNegocio = value; }
        }


        public Especialidades(Business.Logic.EspecialidadLogic especialidad)
        {
            EspecialidadNegocio = especialidad;

        }
        #region MENU
        public void Menu()
        {
            char confir = 'S';
            while (confir == 'S')
            {
                Console.Clear();
                Console.WriteLine("MENU DE ESPECIALIDADES");
                Console.WriteLine("1– Listado General \n2– Consulta \n3– Agregar \n4- Modificar \n5- Eliminar \n6- Salir");
                ConsoleKeyInfo opc = Console.ReadKey();
                switch (opc.Key)
                {
                    case ConsoleKey.D1:
                        {
                            ListadoGeneral();
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            Consulta();
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            Agregar();
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            Modificar();
                            break;
                        }
                    case ConsoleKey.D5:
                        {
                            Eliminar();
                            break;
                        }
                    case ConsoleKey.D6:
                        {
                            break;
                        }
                }
                Console.WriteLine("Desea continuar? S/N");
                confir = char.Parse(Console.ReadLine());
                confir = Char.ToUpper(confir);
            }



        }

        public void ListadoGeneral()
        {

            Console.Clear();
            foreach (Especialidad esp in EspecialidadNegocio.GetAll())
            {
                MostrarDatos(esp);

            }


        }


        public void MostrarDatos(Especialidad esp)
        {
            
            Console.WriteLine("\t\tDescripcion: {0}", esp.Descripcion);
            Console.WriteLine();

        }


        public void Consulta()
        {
            Console.Clear();
            try
            {
                Console.Write("Ingrese la descripcion de la especialidad a consultar: ");
                string descripcion = Console.ReadLine();
                this.MostrarDatos(EspecialidadNegocio.GetOne(descripcion));
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("La descripción ingresada no es válida");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();

            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese la descripción de la especialidad a modificar: ");
                string descripcion = Console.ReadLine();
                Especialidad especialidad = EspecialidadNegocio.GetOne(descripcion);
                especialidad.State = BusinessEntity.States.Modified;
                EspecialidadNegocio.Save(especialidad);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La descripción ingresada no es válida ");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void Agregar()
        {
            Especialidad especialidad = new Especialidad();
            Console.Write("Ingrese descripción: ");
            especialidad.Descripcion = Console.ReadLine();
            especialidad.State = BusinessEntity.States.New;
            EspecialidadNegocio.Save(especialidad);
            Console.WriteLine();
            Console.WriteLine("DESCRIPCIÓN: {0}", especialidad.Descripcion);
        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese la descripción de la especialidad a eliminar: ");
                string descripcion = Console.ReadLine();
                EspecialidadNegocio.Delete(descripcion);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La descripción ingresada no es válida ");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
        #endregion
    }

}
