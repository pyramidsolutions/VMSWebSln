using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVS_BLL.ManagementClasses
{
    public abstract class BaseMangement
    {
        public abstract void insert(Object o);

        public abstract  bool edit(Object o);

        public abstract  bool disable(Object o);

        public abstract  object getAll();

        public abstract  object searchAll(object criteria); 

    }
}
