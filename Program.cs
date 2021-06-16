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
                        listSeries();
                        break;
                    case "2":
                        insertSerie();
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

        private static void listSeries()
        {
            Console.WriteLine("--- Listar Séries ---");
            repository.printList();
        }

        private static void insertSerie()
        {
            Console.WriteLine("--- Inserir nova série ---");

            foreach (var value in Enum.GetValues(typeof(Gender)))
                Console.WriteLine($"{value} - ${Enum.GetName(typeof(Gender), value)}");

            Console.Write("Digite o número respectivo ao gênero entre as opções acima: ");
            int serieGender = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string serieTitle = Console.ReadLine();

            Console.Write("Digite o número respectivo ao gênero entre as opções acima: ");
            int serieYear = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string serieDescription = Console.ReadLine();

            Serie newSerie = new Serie(id: repository.NextID(),
                                        gender: (Gender)serieGender,
                                        title: serieTitle,
                                        year: serieYear,
                                        description: serieDescription
            );

            repository.Insert(newSerie);
        }
    }
}
