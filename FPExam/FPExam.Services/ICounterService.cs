using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPExam.Services
{
    public interface ICounterService
    {
        int GetCount();
        void IncrementCount(int number);
    }
}
