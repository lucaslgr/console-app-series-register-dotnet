using System;

namespace DIO.Series
{
    public class Serie : BaseEntity
    {
        private Gender Gender { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }

        public Serie(int id, Gender gender, string title, string description, int year)
        {
            this.Id = id;
            this.Gender = gender;
            this.Title = title;
            this.Description = description;
            this.Year = year;
        }

        public override string ToString()
        {
            string result = "";
            result += $"Gênero: {this.Gender} {Environment.NewLine}";
            result += $"Título: {this.Title} {Environment.NewLine}";
            result += $"Descrição: {this.Description} {Environment.NewLine}";
            result += $"Ano de Início: {this.Year} {Environment.NewLine}";
            return result;
        }
    }
}