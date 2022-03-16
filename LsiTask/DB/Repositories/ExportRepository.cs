using LsiTask.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LsiTask.DB.Repositories
{
    public class ExportRepository : BaseRepository<Export>
    {
        public ExportRepository(LsiContext context) : base(context)
        {

        }

        public List<Export> GetDataByDate (DateTime date)
        {
            var result = dbSet.Where(p => p.Date == date).ToList();
            return result;
        }
    }
}
