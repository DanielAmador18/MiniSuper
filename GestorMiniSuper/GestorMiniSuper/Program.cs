using Npgsql;

namespace Supersito
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            Ventas venta = new Ventas();
        }
       
        //Conexion con la base de datos SQL mediante un conection string y creacion de un metodo que puede ser llamado
        //para reutilizar codigo.
        public class ConexionDB
        {
        private static string connString = "Host=localhost;Port=5432;Username=postgres;Password=admin123;Database=MiniSuper";

        public static NpgsqlConnection ObtenerConexion()
        {
            var conn = new NpgsqlConnection(connString);
            conn.Open();
            return conn;
        }
    }



public void Menu()
        {
            while (true)
            {
                Console.WriteLine("1.Registrar venta");

                Console.WriteLine("2.Listar productos");

                Console.WriteLine("3.Agregar producto");

                Console.WriteLine("0.Salir");

                Console.WriteLine("Elige una opcion:");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {

                    case 1:
                        venta.RegistrarVenta();
                        break;


                }
            }
        }
    }

    class Inventario
    {

    }

     class Ventas
    {

        public void RegistrarVenta()
        {
            
        }

    }
}
