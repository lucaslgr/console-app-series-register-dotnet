using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepository repository = new SerieRepository();

        static void Main(string[] args)
        {
            string userOption = "";

            while (userOption != "X")
            {
                userOption = GetUserOption();
                switch (userOption)
                {
                    case "1":
                        listSeries();
                        break;
                    case "2":
                        insertSerie();
                        break;
                    case "3":
                        updateSerie();
                        break;
                    case "4":
                        deleteSerie();
                        break;
                    case "5":
                        showSerie();
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

            int serieGender, serieYear;
            string serieTitle, serieDescription;

            menuFillDataSerie(out serieGender, out serieTitle, out serieYear, out serieDescription);

            Serie newSerie = new Serie(id: repository.NextID(),
                                        gender: (Gender)serieGender,
                                        title: serieTitle,
                                        year: serieYear,
                                        description: serieDescription
            );

            repository.Insert(newSerie);
        }

        private static void updateSerie()
        {
            Console.WriteLine("--- Editar série ---");

            Console.Write("Digite o número respectivo ao ID da série que deseja atualizar: ");
            int serieId = int.Parse(Console.ReadLine());

            int serieGender, serieYear;
            string serieTitle, serieDescription;

            menuFillDataSerie(out serieGender, out serieTitle, out serieYear, out serieDescription);

            Serie newSerie = new Serie(id: repository.NextID(),
                                        gender: (Gender)serieGender,
                                        title: serieTitle,
                                        year: serieYear,
                                        description: serieDescription
            );

            repository.Update(serieId, newSerie);
        }

        static private void deleteSerie()
        {
            Console.WriteLine("--- Deletar série ---");

            Console.Write("Digite o número respectivo ao ID da série que deseja excluir: ");
            int serieId = int.Parse(Console.ReadLine());

            if (askConfirmation())
                return;

            repository.Delete(serieId);
        }

        static private void showSerie()
        {
            Console.Write("Digite o número respectivo ao ID da série que deseja visualizar: ");
            int serieId = int.Parse(Console.ReadLine());

            Console.Write(repository.GetByID(serieId));
        }

        static private bool askConfirmation()
        {
            Console.WriteLine("Deseja mesmo executar essa ação? ");
            Console.WriteLine("1 - Sim ");
            Console.WriteLine("2 - Não ");
            int userChoice = int.Parse(Console.ReadLine());

            return (userChoice == 1);
        }

        private static void menuFillDataSerie(
            out int serieGender,
            out string serieTitle,
            out int serieYear,
            out string serieDescription
        )
        {
            foreach (int i in Enum.GetValues(typeof(Gender)))
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Gender), i)}");

            Console.Write("Digite o número respectivo ao gênero entre as opções acima: ");
            serieGender = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            serieTitle = Console.ReadLine();

            Console.Write("Digite o ano que a série foi lançada: ");
            serieYear = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            serieDescription = Console.ReadLine();
        }
    }
}
