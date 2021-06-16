using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepository repository = new SerieRepository();

        static void Main(string[] args)
        {
            string userOption = GetUserOption();

            while (userOption != "X")
            {
                switch (userOption)
                {
                    case "1":
                        repository.List();
                        break;
                    case "2":
                        //repository.Insert("");
                        break;
                    case "3":
                        //
                        break;
                    case "4":
                        //
                        break;
                    case "5":
                        //
                        break;
                    case "6":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException("Opção inválida");
                }
            }
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("--- DIO Séries ---");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("6 - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
    }
}
