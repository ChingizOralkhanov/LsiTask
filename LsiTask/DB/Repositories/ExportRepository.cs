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

        public List<Export> GetDataByDate (DateTime from, DateTime to)
        {
            var result = dbSet.Where(e => (e.Date >= from) && (e.Date <= to)).ToList();
            return result;
        }
    }
}
