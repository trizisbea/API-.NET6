using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsultorioProjeto.Context;
using ConsultorioProjeto.Repository.Interfaces;

namespace ConsultorioProjeto.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly ConsultorioContext _context;

        public BaseRepository(ConsultorioContext context) 
        {
            _context = context;
   
        }
                public ConsultorioContext Context { get; }

        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}