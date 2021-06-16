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
    }
}