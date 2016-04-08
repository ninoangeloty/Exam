using FPExam.Data;
using FPExam.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPExam.Services
{
    public class CounterService : ICounterService
    {
        public CounterService(IUnitOfWork uow)
        {
            this.UnitOfWork = uow;
        }

        public int GetCount()
        {
            var row = this.UnitOfWork.Set<Counter>().FirstOrDefault();

            if (row == null || !row.Counter1.HasValue)
            {
                return 1;
            }
            else
            {
                return row.Counter1.Value;
            }
        }

        public void IncrementCount(int number)
        {
            var row = this.UnitOfWork.Set<Counter>().FirstOrDefault();

            if (row == null)
            {
                this.UnitOfWork.Set<Counter>().Add(new Counter() { Counter1 = number });                
            }
            else
            {
                row.Counter1 = number;
            }

            this.UnitOfWork.Commit();
        }

        private IUnitOfWork UnitOfWork { get; set; }
    }
}
