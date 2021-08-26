using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FStore.Model
{
    public class RepImp : IRepTest
    {
        public IList<Models> GetAll()
        {
            using (var context = new TContexts())
            {
                return context.Furniturestore.ToList();
            }
        }

        public void Add(Models _object)
        {
            using (var context = new TContexts())
            {
                context.Add<Models>(_object);
                context.SaveChanges();
            }
        }
    }
}
