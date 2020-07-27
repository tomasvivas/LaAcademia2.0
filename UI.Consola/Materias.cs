using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using Business.Entities;


namespace UI.Consola
{
    public class Materias
    {
        private Business.Logic.MateriaLogic _MateriaNegocio;

        public Business.Logic.MateriaLogic MateriaNegocio
        {
            get { return _MateriaNegocio; }
            set { _MateriaNegocio = value; }
        }


        public Materias(Business.Logic.MateriaLogic mat)
        {
            MateriaNegocio = mat;
        }

        #region MENU

        public void Menu()
        {
            char confir = 'S';
            while (confir == 'S')
            {
                Console.Clear();
                Console.WriteLine("MENU DE MATERIAS");
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
            foreach (Materia mat in MateriaNegocio.GetAll())
            {
                MostrarDatos(mat);

            }

        }

        public void MostrarDatos(Materia mat)
        {
            Console.WriteLine("Materia: {0}", mat.ID);
            Console.WriteLine("\t\tHoras semanales: {0}", mat.HSSemanales);
            Console.WriteLine("\t\tHoras totales: {0}", mat.HSTotales);
            Console.WriteLine("\t\tPlan al que pertenece:{0}", mat.IDPlan);
            Console.WriteLine();
        }

        public void Consulta()
        {
            Console.Clear();
            try
            {
                Console.Write("Ingrese el ID de la materia a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(MateriaNegocio.GetOne(ID));
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
                Console.Write("Ingrese el ID de la materia a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Materia mat = MateriaNegocio.GetOne(ID);
                Console.Write("Ingrese descripcion: ");
                mat.Descripcion = Console.ReadLine();
                Console.Write("Ingrese horas semanales: ");
                mat.HSSemanales = int.Parse(Console.ReadLine());
                Console.Write("Ingrese horas totales: ");
                mat.HSTotales = int.Parse(Console.ReadLine());
                Console.Write("Ingrese ID del plan al que pertenece: ");
                mat.IDPlan = int.Parse(Console.ReadLine());
                mat.State = BusinessEntity.States.Modified;
                MateriaNegocio.Save(mat);
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
            Materia mat = new Materia();
            Console.Write("Ingrese descripcion: ");
            mat.Descripcion = Console.ReadLine();
            Console.Write("Ingrese horas semanales: ");
            mat.HSSemanales = int.Parse(Console.ReadLine());
            Console.Write("Ingrese horas totales: ");
            mat.HSTotales = int.Parse(Console.ReadLine());
            Console.Write("Ingrese ID del plan al que pertence: ");
            mat.IDPlan = int.Parse(Console.ReadLine());
            mat.State = BusinessEntity.States.New;
            MateriaNegocio.Save(mat);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", mat.ID);
        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID de la materia a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                MateriaNegocio.Delete(ID);
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
