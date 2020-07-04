using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using Business.Entities;


namespace UI.Consola
{
    public class Usuarios
    {
        private Business.Logic.UsuarioLogic _UsuarioNegocio;

        public Business.Logic.UsuarioLogic UsuarioNegocio
        {
            get { return _UsuarioNegocio; }
            set { _UsuarioNegocio = value; }
        }
        

        public Usuarios(Business.Logic.UsuarioLogic user)
        {
            UsuarioNegocio = user;  
        }

        #region METODOS 
        public void Menu()
        {
            char confir = 'S';
            while (confir == 'S')
            {
                Console.Clear();
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
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);

            }
            

        }


        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("Usuario: {0}", usr.ID);
            Console.WriteLine("\t\tNombre: {0}", usr.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usr.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0} ", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.Email);
            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);

            Console.WriteLine();
        }


        public void Consulta()
        {
            Console.Clear();
            try
            {
                Console.Write("Ingrese el ID del usuario a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(ID));
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
                Console.Write("Ingrese el ID del usuario a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.GetOne(ID);
                Console.Write("Ingrese nombre: ");
                usuario.Nombre = Console.ReadLine();
                Console.Write("Ingrese apellido: ");
                usuario.Apellido = Console.ReadLine();
                Console.Write("Ingrese nombre de usuario: ");
                usuario.NombreUsuario = Console.ReadLine();
                Console.Write("Ingrese clave: ");
                usuario.Clave = Console.ReadLine();
                Console.Write("Ingrese email: ");
                usuario.Email = Console.ReadLine();
                Console.Write("Ingrese habilitacion de usuario (1-Si/otro-No): ");
                usuario.Habilitado = (Console.ReadLine() == "1");
                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);
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
            Usuario usuario = new Usuario();
            Console.Write("Ingrese nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.Write("Ingrese apellido: ");
            usuario.Apellido = Console.ReadLine();
            Console.Write("Ingrese nombre de usuario: ");
            usuario.NombreUsuario = Console.ReadLine();
            Console.Write("Ingrese clave: ");
            usuario.Clave = Console.ReadLine();
            Console.Write("Ingrese email: ");
            usuario.Email = Console.ReadLine();
            Console.Write("Ingrese habilitacion de usuario (1-Si/otro-No): ");
            usuario.Habilitado = (Console.ReadLine() == "1");
            usuario.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(usuario);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", usuario.ID); 
        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del usuario a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(ID); 
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
