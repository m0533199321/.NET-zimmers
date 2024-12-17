using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zimmers.core.Interfaces
{
    public interface ICopyable<T> 
    {
        void Copy(T a, T b);
    }
}
