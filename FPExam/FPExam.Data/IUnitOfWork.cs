using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPExam.Data
{
    public interface IUnitOfWork
    {
        void Commit();
        IDbSet<T> Set<T>() where T : class;
        T As<T>() where T : class;
    }
}
