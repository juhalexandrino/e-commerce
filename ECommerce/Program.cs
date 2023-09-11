using System;

namespace ECommerce
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int entrada, id;

            while (true)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("            DigiFlores              ");
                Console.WriteLine("====================================");
                Console.WriteLine("  1 - Cadastrar novo produto        ");
                Console.WriteLine("  2 - Listar todos produtos         ");
                Console.WriteLine("  3 - Buscar produto por ID         ");
                Console.WriteLine("  4 - Atualizar produto             ");
                Console.WriteLine("  5 - Apagar produto                ");
                Console.WriteLine("  6 - Sair do programa              ");
                Console.WriteLine("====================================");

                Console.WriteLine("\nEscolha a opção desejada: ");
                entrada = Convert.ToInt32(Console.ReadLine());

                    switch (entrada)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Cadastrar novo produto");
                            Console.ResetColor();
                        KeyPress();
                        break;

                        case 2:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Listar todos os produtos");
                            Console.ResetColor();
                        KeyPress();
                        break;

                        case 3:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Buscar produto por ID");
                            Console.ResetColor();
                        KeyPress();
                        break;

                        case 4:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Atualizar produto");
                            Console.ResetColor();
                        KeyPress();
                        break;

                        case 5:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Apagar produto");
                            Console.ResetColor();
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