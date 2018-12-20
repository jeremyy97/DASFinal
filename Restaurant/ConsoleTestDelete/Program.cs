using BusinessLogic;
using DBAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestDelete
{
    class Program
    {
        static User LoggedUser;
        static UserLogic Userlogic;
        static TableLogic Tablelogic = new TableLogic();
        static ProductLogic Produclogic = new ProductLogic();
        static OrderLogic Orderlogic = new OrderLogic();
        static void Main(string[] args)
        {
            LoggedUser = new User();
            Menu();

        }

        public static void Menu()
        {
            Userlogic = new UserLogic();
            Boolean continuar = true;
            while (continuar)
            {
                Console.WriteLine("***Bienvenido a nuestro sistema.***");
                Console.WriteLine("Ingrese su nombre de usuario:");
                string username = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña:");
                string password = Console.ReadLine();
                LoggedUser = Userlogic.Login(username, password);
                if (LoggedUser != null)
                {
                    switch (LoggedUser.Type)
                    {
                        case "admin":
                            AdminMenu();
                            break;
                        case "waiter":
                            WaiterMenu();
                            break;
                        case "table":
                            TableMenu();
                            break;
                        case "cashier":
                            CashierMenu();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("El usuario o la contraseña ingresado son incorrectos.");
                }
            }
        }

        public static void AdminMenu()
        {
            Boolean continuar = true;
            while (continuar)
            {
                Console.WriteLine("Ingrese el numero que antescede la opcion que desea \n\n1.Crear un nuevo usuario" +
                    "\n2.Deshabilitar un usuario \n3.Crear una nueva mesa \n4.Crear un producto" +
                    "\n5.Eliminar un producto. \n6.Cerrar Sesion");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nuevo nombre de usuario");
                        string NewUsername = Console.ReadLine();
                        Console.WriteLine("Ingrese la contraseña para " + NewUsername);
                        string Password = Console.ReadLine();
                        Console.WriteLine("Ingrese nombre");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Ingrese apellido");
                        string Lastname = Console.ReadLine();
                        Console.WriteLine("Ingrese el tipo de usuario (admin,waiter,table,cashier)");
                        string type = Console.ReadLine();
                        User lastUser = Userlogic.CreateUser(NewUsername, Password, Name, Lastname, type);
                        if (lastUser != null)
                            Console.WriteLine("Usuario creado correctamente");
                        else
                            Console.WriteLine("Los datos ingresados fueron incorrectos");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el nombre de usuario");
                        string Username = Console.ReadLine();
                        Userlogic.DisableUser(Username, LoggedUser.Username);
                        Console.WriteLine("Usuario deshabilitado correctamente");
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el ID de mesa");
                        int table_id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantindad de personas de la mesa");
                        int people = Convert.ToInt32(Console.ReadLine());
                        Tablelogic.AddTable(table_id, people);
                        Console.WriteLine("Mesa creada correctamente.");
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el id del producto");
                        int product_id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el nombre del producto");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ingrese la descripcion del producto");
                        string description = Console.ReadLine();
                        Console.WriteLine("Ingrese el costo del producto");
                        decimal cost = Convert.ToDecimal(Console.ReadLine());
                        Produclogic.AddProduct(product_id, name, description, cost);
                        Console.WriteLine("Producto creado correctamente");
                        break;
                    case 5:
                        Console.WriteLine("Ingrese el id del producto");
                        int product_id_delete = Convert.ToInt32(Console.ReadLine());
                        Produclogic.DeleteProduct(product_id_delete);
                        Console.WriteLine("Producto eliminado correctamente");
                        break;
                    case 6:
                        continuar = false;
                        Console.WriteLine("La sesion ha terminado.");
                        break;
                    default:
                        Console.WriteLine("El numero ingresado no coincide con ninguna de las opciones");
                        break;
                }
            }
        }

        public static void WaiterMenu()
        {
            Boolean continuar = true;
            while (continuar)
            {
                Console.WriteLine("Ingrese el numero que antescede la opcion que desea \n\n1.Elegir mesa y ordernar" +
                    "\n2.Cerrar Sesion");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        List<Table> tables = Tablelogic.GetAvailableTables();
                        string tableList = "";
                        foreach (var i in tables)
                        {
                            tableList += i.ID + ". Cantidad de personas: " + i.People + "\n"; 
                        }
                        Console.WriteLine("****MESAS DISPONIBLES**** \n\n" + tableList);
                        Console.WriteLine("Ingrese el id de la mesa en la que desea ordear");
                        int table_id = Convert.ToInt16(Console.ReadLine());
                        Tablelogic.PickTable(table_id);
                        Boolean continuarOrdenando = true;
                        List<Product> products = Produclogic.GetProducts();
                        string productList = "";
                        foreach (var i in products)
                        {
                            productList += i.ID + ". " + i.Name + ". " + i.Description + ". Costo: " +i.Cost +"\n";
                        }
                        Console.WriteLine("****LISTA DE PRODUCTOS**** \n\n" + productList);
                        while (continuarOrdenando)
                        {
                            Console.WriteLine("Ingrese el id del producto para ordenar. Pulsa 0 a para salir.");
                            int optionOrder = Convert.ToInt32(Console.ReadLine());
                            if (optionOrder == 0)
                            {
                                continuarOrdenando = false;
                            }
                            else
                            {
                                Order_Product orden = Orderlogic.CreateOrder(table_id, optionOrder, Produclogic.SearchByID(optionOrder).Cost);
                                Console.WriteLine("Se realizo la orden " + orden.ID);
                            }
                        }
                        break;
                    case 2:
                        continuar = false;
                        break;
                }
            }
        }
        public static void TableMenu()
        {
            int table_id = Convert.ToInt16(LoggedUser.LastName);
            Tablelogic.PickTable(table_id);
            Boolean continuarOrdenando = true;
            List<Product> products = Produclogic.GetProducts();
            string productList = "";
            foreach (var i in products)
            {
                productList += i.ID + ". " + i.Name + ". " + i.Description + ". Costo: " + i.Cost + "\n";
            }
            Console.WriteLine("****LISTA DE PRODUCTOS**** \n\n" + productList);
            while (continuarOrdenando)
            {
                Console.WriteLine("Ingrese el id del producto para ordenar. Pulsa 0 a para salir.");
                int optionOrder = Convert.ToInt32(Console.ReadLine());
                if (optionOrder == 0)
                {
                    continuarOrdenando = false;
                    Console.WriteLine("La sesion se ha terminado. Se desea seguir ordenando inicie sesion nuevamente.");
                }
                else
                {
                    Order_Product orden = Orderlogic.CreateOrder(table_id, optionOrder, Produclogic.SearchByID(optionOrder).Cost);
                    Console.WriteLine("Se realizo la orden " + orden.ID);
                }
            }
        }

        public static void CashierMenu()
        {
            Console.WriteLine("Digite el numero de mesa: ");
            int table_id = Convert.ToInt16(Console.ReadLine());
            BillLogic billLogic = new BillLogic(table_id);
            foreach (var order in billLogic.OrdersToPayInTheSameTable)
            {
                Console.WriteLine(order.ID + ". Mesa: " +order.Table + ". " + order.Product.Name+ "\n");
            }
            int answer;
            do
            {
                Console.WriteLine("Digite la orden que desea agregar: ");
                int orderid = Convert.ToInt16(Console.ReadLine());
                billLogic.AddOrderToABill(orderid);
                Console.WriteLine("Desea agregar otra orden: 1-Si 2-No");
                answer = Convert.ToInt16(Console.ReadLine());
            } while (answer == 1);
            Console.WriteLine("Digite el nombre para la factura: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Digite el id para la factura: ");
            int id = Convert.ToInt16(Console.ReadLine());
            Bill bill = billLogic.CreateBill(id, nombre);
            Console.WriteLine(bill.Name + bill.Orders + bill.Tax + bill.Cost + bill.FinalCost);
        }
    }
}
