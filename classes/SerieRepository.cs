using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listSerie = new List<Serie>();

        public void Delete(int id)
        {
            this.listSerie[id].delete();
        }

        public Serie GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Serie entity)
        {
            this.listSerie.Add(entity);
        }

        public List<Serie> List()
        {
            return this.listSerie;
        }

        public int NextID()
        {
            return this.listSerie.Count;
        }

        public void Update(int id, Serie entity)
        {
            this.listSerie[id] = entity;
        }

        public void printList()
        {
            Console.WriteLine("--- Listar Séries ---");

            if (this.listSerie.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada");
                return;
            }

            foreach (var serie in this.listSerie)
            {
                Console.WriteLine($"#ID {serie.getId()} - {serie.getTitle()}");
            }
        }
    }
}