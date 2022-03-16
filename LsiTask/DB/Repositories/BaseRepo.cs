using LsiTask.DB.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LsiTask.DB.Repositories
{
    public abstract class BaseRepository<Model> where Model: BaseModel
    {
        protected LsiContext context;
        protected DbSet<Model> dbSet;

        public BaseRepository(LsiContext context)
        {
            this.context = context;
            dbSet = context.Set<Model>();
        }

        public Model Get(long id)
        {
            return dbSet.SingleOrDefault(x => x.ID == id);
        }

        public List<Model> GetAll()
        {
            return dbSet.ToList();
        }

        public void Save(Model model)
        {
            if (model.ID > 0)
            {
                dbSet.Update(model);
                context.SaveChanges();
                return;
            }

            dbSet.Add(model);
            context.SaveChanges();
        }

        public void Delete(long id)
        {
            var model = Get(id);
            dbSet.Remove(model);
            context.SaveChanges();
        }
    }
}
