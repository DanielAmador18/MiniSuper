namespace Supersito
{
    class program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            Ventas ventas = new Ventas();
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

                    case 1: ventas.RegistrarVenta();break;


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
