using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listSerie = new List<Serie>();

        void IRepository<Serie>.Delete(int id)
        {
            this.listSerie[id].delete();
        }

        Serie IRepository<Serie>.GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        void IRepository<Serie>.Insert(Serie entity)
        {
            this.listSerie.Add(entity);
        }

        List<Serie> IRepository<Serie>.List()
        {
            return this.listSerie;
        }

        int IRepository<Serie>.NextID()
        {
            throw new System.NotImplementedException();
        }

        void IRepository<Serie>.Update(int id, Serie entity)
        {
            this.listSerie[id] = entity;
        }
    }
}