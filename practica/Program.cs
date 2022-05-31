using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    class Program
    {
        static void Main(string[] args)
        {
            byte opcionPrincipal = 0;
            
            while (opcionPrincipal != 3)
            {
                Console.Clear();
                opcionPrincipal = menuPrincipal();
                if (opcionPrincipal == 1)
                {
                    byte opcionBases = 0;
                    while (opcionBases != 5)
                    {
                        Console.Clear();
                        opcionBases = menuBases();
                        if (opcionBases == 1)
                        {
                            areaRectangulo();
                        }
                        if (opcionBases == 2)
                        {
                            areaCuadrado();
                        }
                        if (opcionBases == 3)
                        {
                            areaCirculo();
                        }
                        if (opcionBases == 4)
                        {
                            areaTriangulo();
                        }
                    }

                }
                if (opcionPrincipal == 2)
                {
                    precioArticulo();
                }
            }

        }

        private static void precioArticulo()
        {
            Console.Clear();
            mensajeArticulo();
            Console.WriteLine("\nDigite el precio costo del articulo: ");
            double precioInicial = int.Parse(Console.ReadLine());
            double precioDescuento = precioInicial-(precioInicial * 0.2);
            double precioIVA = precioDescuento + (precioDescuento * 13 / 100);
            Console.WriteLine("\nEl precio Original: "+precioInicial+"\nPrecio con descuento: "+precioDescuento+
                "\nPrecio Total: "+precioIVA);
            Console.ReadKey();
        }

        private static void mensajeArticulo()
        {
            Console.WriteLine("\nA cada usuario se le aplicará un 20% de descuento por cada articulo");
            Console.WriteLine("Considerando que deberá pagar el IVA, porcentaje que varía según la legislación actual");

        }

        private static void areaTriangulo()
        {
            Console.Clear();
            Console.WriteLine("\nDigite la base: ");
            int bases = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite la altura: ");
            int altura = int.Parse(Console.ReadLine());
            int resultado = (bases * altura)/2;
            Console.WriteLine("\nEl area del rectangulo es: " + resultado);
            Console.ReadKey();
        }

        private static void areaCirculo()
        {
            Console.Clear();
            double pi = 3.1416;
            Console.WriteLine("\nDigite el radio del circulo: ");
            int radio = int.Parse(Console.ReadLine());
            double resultado = pi * (radio*radio);
            Console.WriteLine("\nEl area del ciculo es: " + resultado);
            Console.ReadKey();
        }

        private static void areaCuadrado()
        {
            Console.Clear();
            Console.WriteLine("\nDigite el largo de un lado: ");
            int lado = int.Parse(Console.ReadLine());
            int resultado = lado * lado;
            Console.WriteLine("\nEl area del cuadrado es: " + resultado);
            Console.ReadKey();
        }

        private static void areaRectangulo()
        {
            Console.Clear();
            Console.WriteLine("\nDigite el largo: ");
            int largo = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite el ancho: ");
            int ancho = int.Parse(Console.ReadLine());
            int resultado = largo * ancho;
            Console.WriteLine("\nEl area del rectangulo es: " + resultado);
            Console.ReadKey();
        }

        private static byte menuBases()
        {
            Console.WriteLine("\n\tMenu Áreas\n");
            Console.WriteLine("1.Rectangulo");
            Console.WriteLine("2.Cuadrado");
            Console.WriteLine("3.Circulo");
            Console.WriteLine("4.Triangulo");
            Console.WriteLine("5.Salir");
            Console.WriteLine("Digite la opcion que desea realizar: ");
            byte opcion = byte.Parse(Console.ReadLine());
            return opcion;

        }

        private static byte menuPrincipal()
        {
            
            Console.WriteLine("\n\tMenu principal\n");
            Console.WriteLine("1.Áreas");
            Console.WriteLine("2.Precio Articulo");
            Console.WriteLine("3.Salir\n");
            Console.WriteLine("Digite la opcion que desea realizar: ");
            byte opcion = byte.Parse(Console.ReadLine());
            return opcion;
        }
    }
}



