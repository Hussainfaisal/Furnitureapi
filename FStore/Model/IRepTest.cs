using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FStore.Model
{
    public interface IRepTest
    {

        IList<Models> GetAll();
        void Add(Models addObj);
    }
}
