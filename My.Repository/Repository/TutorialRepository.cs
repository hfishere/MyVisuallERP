using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using My.Repository.Interfaces;
using My.DAL;

namespace My.Repository.Repository
{
    public class TutorialRepository : IEntityRepository<dbtutorial, int>
    {
        ERPEntities context = new ERPEntities();
        public void Delete(int id)
        {
            var tutor = this.Search(id);
            context.dbtutorials.Remove(tutor);
            context.SaveChanges();
        }

        public IQueryable<dbtutorial> GetAllData()
        {
            var tutor = from t in context.dbtutorials select t;
            return tutor;
        }

        public void Insert(dbtutorial entity)
        {
            try
            {
                context.dbtutorials.Add(entity);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public dbtutorial Search(int id)
        {
            var tutor = context.dbtutorials.Find(id);
            return tutor;
        }

        public void Update(dbtutorial entity)
        {
            try
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
