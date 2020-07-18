using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using Business.Entities;

namespace UI.Consola
{
    class Planes
    {
        private Business.Logic.PlanLogic _PlanNegocio;

        public Business.Logic.PlanLogic PlanNegocio
        {
            get { return _PlanNegocio; }
            set { _PlanNegocio = value; }
        }


        public Planes(Business.Logic.PlanLogic plan)
        {
            PlanNegocio = plan;
        }

        #region MENU

        public void Menu()
        {
            char confir = 'S';
            while (confir == 'S')
            {
                Console.Clear();
                Console.WriteLine("MENU DE PLANES");
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
            foreach (Plan plan in PlanNegocio.GetAll())
            {
                MostrarDatos(plan);

            }

        }

        public void MostrarDatos(Plan plan)
        {
            Console.WriteLine("Plan: {0}", plan.ID);
            Console.WriteLine("\t\tDescripcion: {0}", plan.Descripcion);
            Console.WriteLine("\t\tEspecilidad: {0}", plan.IDEspecialidad);
            Console.WriteLine();
        }

        public void Consulta()
        {
            Console.Clear();
            try
            {
                Console.Write("Ingrese el ID del plan a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(PlanNegocio.GetOne(ID));
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un número entero");
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
                Console.Write("Ingrese el ID del plan a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Plan plan = PlanNegocio.GetOne(ID);
                Console.Write("Ingrese descripcion: ");
                plan.Descripcion = Console.ReadLine();
                Console.Write("Ingrese especialidad: ");
                plan.IDEspecialidad = int.Parse(Console.ReadLine());
                plan.State = BusinessEntity.States.Modified;
                PlanNegocio.Save(plan);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresa debe ser un numero entero: ");
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
            Plan plan = new Plan();
            Console.Write("Ingrese descripcion: ");
            plan.Descripcion = Console.ReadLine();
            Console.Write("Ingrese especialidad: ");
            plan.IDEspecialidad = int.Parse(Console.ReadLine());
            plan.State = BusinessEntity.States.New;
            PlanNegocio.Save(plan);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", plan.ID);
        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del plan a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                PlanNegocio.Delete(ID);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresa debe ser un numero entero: ");
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
