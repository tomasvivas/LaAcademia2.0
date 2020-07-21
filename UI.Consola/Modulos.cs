using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Consola
{
    class Modulos
    {
        private Business.Logic.ModuloLogic _ModuloNegocio;

        public Business.Logic.ModuloLogic ModuloNegocio
        {
            get { return _ModuloNegocio; }
            set { _ModuloNegocio = value; }
        }

        public Modulos(Business.Logic.ModuloLogic modulo)
        {
            ModuloNegocio = modulo;

        }

        #region MENU
        public void Menu()
        {
            char confir = 'S';
            while (confir == 'S')
            {
                Console.Clear();
                Console.WriteLine("MENU DE MODULOS");
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
            foreach (Modulo mod in ModuloNegocio.GetAll())
            {
                MostrarDatos(mod);

            }


        }

        public void MostrarDatos(Modulo mod)
        {

            Console.WriteLine("\t\tDescripcion: {0}", mod.Descripcion);
            Console.WriteLine();

        }

        public void Consulta()
        {
            Console.Clear();
            try
            {
                Console.Write("Ingrese la descripcion del modulo a consultar: ");
                string descripcion = Console.ReadLine();
                this.MostrarDatos(ModuloNegocio.GetOne(descripcion));
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
                Console.Write("Ingrese la descripción del modulo a modificar: ");
                string descripcion = Console.ReadLine();
                Modulo modulo = ModuloNegocio.GetOne(descripcion);
                modulo.State = BusinessEntity.States.Modified;
                ModuloNegocio.Save(modulo);
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
            Modulo modulo = new Modulo();
            Console.Write("Ingrese descripción: ");
            modulo.Descripcion = Console.ReadLine();
            modulo.State = BusinessEntity.States.New;
            ModuloNegocio.Save(modulo);
            Console.WriteLine();
            Console.WriteLine("DESCRIPCIÓN: {0}", modulo.Descripcion);
        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese la descripción del modulo a eliminar: ");
                string descripcion = Console.ReadLine();
                ModuloNegocio.Delete(descripcion);
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
