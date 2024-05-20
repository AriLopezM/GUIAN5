using System;
using System.Collections.Generic;

namespace Guia5HS
{
    class Program
    {
        static List<Telefono> inventario = new List<Telefono>();

        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n--- Menú Principal ---");
                Console.WriteLine("1. Registrar Teléfono");
                Console.WriteLine("2. Mostrar Teléfonos Registrados");
                Console.WriteLine("3. Consultar Stock de un Teléfono Específico");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        RegistrarTelefono();
                        break;
                    case "2":
                        MostrarTelefonosRegistrados();
                        break;
                    case "3":
                        ConsultarStock();
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }

        static void RegistrarTelefono()
        {
            Console.Write("Ingrese el tipo de teléfono (1. Inteligente, 2. Básico): ");
            string tipo = Console.ReadLine();

            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            Console.Write("Stock: ");
            int stock = int.Parse(Console.ReadLine());
            D
            if (tipo == "1")
            {
                Console.Write("Sistema Operativo: ");
                string sistemaOperativo = Console.ReadLine();
                Console.Write("Memoria RAM (GB): ");
                int memoriaRam = int.Parse(Console.ReadLine());

                TelefonoInteligente telefonoInteligente = new TelefonoInteligente
                {
                    Marca = marca,
                    Modelo = modelo,
                    Precio = precio,
                    Stock = stock,
                    SistemaOperativo = sistemaOperativo,
                    MemoriaRam = memoriaRam
                };

                inventario.Add(telefonoInteligente);
            }
            else if (tipo == "2")
            {
                Console.Write("Tiene Radio FM (true/false): ");
                bool tieneRadioFM = bool.Parse(Console.ReadLine());
                Console.Write("Tiene Linterna (true/false): ");
                bool tieneLinterna = bool.Parse(Console.ReadLine());

                TelefonoBasico telefonoBasico = new TelefonoBasico
                {
                    Marca = marca,
                    Modelo = modelo,
                    Precio = precio,
                    Stock = stock,
                    TieneRadioFM = tieneRadioFM,
                    TieneLinterna = tieneLinterna
                };

                inventario.Add(telefonoBasico);
            }
            else
            {
                Console.WriteLine("Tipo de teléfono no válido.");
            }
        }

        static void MostrarTelefonosRegistrados()
        {
            foreach (var telefono in inventario)
            {
                if (telefono is TelefonoInteligente inteligente)
                {
                    inteligente.MostrarInformacionInteligente();
                }
                else if (telefono is TelefonoBasico basico)
                {
                    basico.MostrarInformacionBasico();
                }
                Console.WriteLine();
            }
        }

        static void ConsultarStock()
        {
            Console.Write("Ingrese el modelo del teléfono a consultar: ");
            string modelo = Console.ReadLine();

            var telefono = inventario.Find(t => t.Modelo == modelo);

            if (telefono != null)
            {
                telefono.MostrarInformacion();
            }
            else
            {
                Console.WriteLine("Teléfono no encontrado.");
            }
        }
    }
}