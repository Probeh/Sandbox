using Library.Models.Commerce;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bonkers.Data
{
    public interface IDataRepository<TModel> where TModel : BaseModel<TModel>
    {
        Task<IEnumerable<TModel>> GetData();
    }
    public class DataRepository<TModel> : IDataRepository<TModel> where TModel : BaseModel<TModel>
    {
        private readonly DataContext _context;

        public DataRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TModel>> GetData()
        {
            return await _context.Set<TModel>().ToListAsync();
        }
    }
}
