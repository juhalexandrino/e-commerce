using ECommerce.Model;
using System;
using ECommerce.Controller;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ECommerce
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int entrada, id, tipoDeArranjo;
            string flor, tipoVaso, elementoAdicional;
            decimal valor;

            ProdutoController produto = new();

            ArranjoBoho ab = new ArranjoBoho(produto.GerarId(), 1, "Rosas", 250, "natural");
            produto.Cadastrar(ab);

            ArranjoVegetativo av = new ArranjoVegetativo(produto.GerarId(), 2, "Margaridas", 580, "Placas com mensagens de amor");
            produto.Cadastrar(av);

            while (true)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("   DigiFlores - A sua floricultura digital   ");
                Console.WriteLine("=============================================");
                Console.WriteLine("  1 - Cadastrar novo produto        ");
                Console.WriteLine("  2 - Listar todos produtos         ");
                Console.WriteLine("  3 - Buscar produto por ID         ");
                Console.WriteLine("  4 - Atualizar produto             ");
                Console.WriteLine("  5 - Apagar produto                ");
                Console.WriteLine("  6 - Sair do programa              ");
                Console.WriteLine("=============================================");

                try
                {
                    Console.Write("\nEscolha a opção desejada: ");
                    entrada = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Por favor, digite um valor inteiro entre 1 e 6.");
                    entrada = 0;
                    Console.ResetColor();
                }

                switch (entrada)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Cadastrar novo produto");
                            Console.ResetColor();

                        Console.Write("Digite o nome da flor: ");
                        flor = Console.ReadLine();

                        Console.Write("Digite o valor do arranjo: ");
                        valor = Convert.ToInt32(Console.ReadLine());

                        do
                        {
                            Console.Write("Digite o tipo de arranjo (1- Boho / 2- Vegetativo): ");
                            tipoDeArranjo = Convert.ToInt32(Console.ReadLine());
                        } while (tipoDeArranjo != 1 && tipoDeArranjo != 2);

                        switch (tipoDeArranjo)
                        {
                            case 1:
                                Console.Write("Digite o tipo de vaso: ");
                                tipoVaso = Console.ReadLine();

                                produto.Cadastrar(new ArranjoBoho(produto.GerarId(), tipoDeArranjo, flor, valor, tipoVaso));
                                break;

                            case 2:
                                Console.Write("Digite o elemento adicional: ");
                                elementoAdicional = Console.ReadLine();

                                produto.Cadastrar(new ArranjoVegetativo(produto.GerarId(), tipoDeArranjo, flor, valor, elementoAdicional));
                                break;
                        }

                        KeyPress();
                        break;

                        case 2:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Listar todos os produtos");
                            Console.ResetColor();

                        produto.ListarTodos();
                        KeyPress();
                        break;

                        case 3:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Buscar produto por ID");
                            Console.ResetColor();

                        Console.Write("Digite o ID do produto: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        produto.ProcurarPorId(id);

                        KeyPress();
                        break;

                        case 4:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Atualizar produto");
                            Console.ResetColor();

                        Console.Write("Digite o ID do produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        var produtos = produto.BuscarNaCollection(id);

                        if (produtos is not null)
                        {
                            Console.Write("Digite o nome da flor: ");
                            flor = Console.ReadLine();

                            Console.Write("Digite o valor do arranjo: ");
                            valor = Convert.ToInt32(Console.ReadLine());

                            flor ??= string.Empty;

                            tipoDeArranjo = produtos.GetTipoDeArranjo();

                            switch (tipoDeArranjo)
                            {
                                case 1:
                                    Console.Write("Digite o tipo de vaso: ");
                                    tipoVaso = Console.ReadLine();

                                    produto.Atualizar(new ArranjoBoho(produto.GerarId(), tipoDeArranjo, flor, valor, tipoVaso));
                                    break;

                                case 2:
                                    Console.Write("Digite o elemento adicional: ");
                                    elementoAdicional = Console.ReadLine();

                                    produto.Atualizar(new ArranjoVegetativo(produto.GerarId(), tipoDeArranjo, flor, valor, elementoAdicional));
                                    break;
                            }

                            KeyPress();
                        }
                        break;

                        case 5:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Apagar produto");
                            Console.ResetColor();

                            Console.Write("Digite o número da conta: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            produto.Deletar(id);

                        KeyPress();
                        break;

                        case 6:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Agradecemos por usar nosso sistema!");
                            Console.ResetColor();
                            System.Environment.Exit(0);
                        KeyPress();
                        break;

                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Opção inválida!");
                            Console.ResetColor();
                        KeyPress();
                        break;

                    }

                static void KeyPress()
                {
                    do
                    {
                        Console.Write("\nPressione enter para continuar...");
                        consoleKeyInfo = Console.ReadKey();
                    } while (consoleKeyInfo.Key != ConsoleKey.Enter);

                }
            }
        }
    }
}