using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPExam.Data
{
    public class UnitOfWork<TContext> : IUnitOfWork
        where TContext : DbContext, new()
    {
        private readonly TContext _context;

        public UnitOfWork()
        {
            _context = new TContext();
        }

        public IDbSet<T> Set<T>() where T : class
        {
            return _context.Set<T>();
        }

        public T As<T>() where T : class
        {
            return _context as T;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
